using Commons.Xml.Relaxng;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestService.Model;
using RestService.Utils;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;
using RabbitMQ.Client;
using Constants = RestService.Model.Constants;
using System.Text;

namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GotController : ControllerBase
    {
        private string nameSpace = "http://schemas.datacontract.org/2004/07/RestService.Model";
        private bool valid = true;
        private List<GameOfThronesCharacter> GameOfThronesCharacters;
        private IModel Kanal;

        public GotController(List<GameOfThronesCharacter> gameOfThronesCharacters, IModel kanal)
        {
            GameOfThronesCharacters = gameOfThronesCharacters;
            Kanal = kanal;
        }

        public List<GameOfThronesCharacter> Get() => GameOfThronesCharacters;

        [HttpPost("XSD")]
        public void Post(XmlElement xmlCharacter)
        {
            try
            {
                XmlDocument document = xmlCharacter.OwnerDocument;
                document.AppendChild(xmlCharacter);
                document.Schemas.Add(nameSpace, Constants.xsdPath);

                ValidationEventHandler handler = new ValidationEventHandler(XmlValid);
                document.Validate(XmlValid);

                if (valid)
                {
                    saveXmlAndAddCharacter(xmlCharacter);
                    HttpContext.Response.StatusCode = StatusCodes.Status202Accepted;
                }
                else
                {
                    Response.StatusCode = StatusCodes.Status206PartialContent;
                }
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        [HttpPost("RNG")]
        public void XmlAgainstRNG(XmlElement xmlCharacter)
        {
            XmlDocument document = xmlCharacter.OwnerDocument;
            document.AppendChild(xmlCharacter);
            MemoryStream memoryStream = new MemoryStream();
            document.Save(memoryStream);

            memoryStream.Flush();
            memoryStream.Position = 0;

            XmlTextReader xmlStreamReader = new XmlTextReader(memoryStream);
            XmlReader xmlValidRng = new XmlTextReader(Constants.rngPath);
            using (RelaxngValidatingReader reader = new RelaxngValidatingReader(xmlStreamReader, xmlValidRng))
            {
                try
                {
                    while (!reader.EOF)
                    {
                        reader.Read();
                    }

                    saveXmlAndAddCharacter(xmlCharacter);
                    Response.StatusCode = StatusCodes.Status202Accepted;
                }
                catch (Exception)
                {
                    Response.StatusCode = StatusCodes.Status206PartialContent;
                }
            }
        }

        private void saveXmlAndAddCharacter(XmlElement xmlCharacter)
        {
            string ns = xmlCharacter.OuterXml;
            string strXMLPattern = @"xmlns(:\w+)?=""([^""]+)""|xsi(:\w+)?=""([^""]+)""";
            ns = Regex.Replace(ns, strXMLPattern, "");
            using (StreamWriter writer = new StreamWriter(Constants.xmlPath))
            {
                writer.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                writer.Write(ns);
            }
            
            XmlHandler xmlHandler = new XmlHandler();
            string character = xmlHandler.getCharacterXML();

            XDocument xmlDoc = XDocument.Parse(character);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GameOfThronesCharacter));
            var addedCharacter = (GameOfThronesCharacter)xmlSerializer.Deserialize(xmlDoc.CreateReader());

            GameOfThronesCharacters.Add(addedCharacter);

            string poruka = string.Format("Added new got character, {0}", addedCharacter.FirstName);
            byte[] podaci = Encoding.UTF8.GetBytes(poruka);
            Kanal.BasicPublish("", "GOT_CHARACTERS", null, podaci);
        }

        private void XmlValid(object? sender, ValidationEventArgs e)
        {
            valid = false;
        }
    }
}
