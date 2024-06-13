using Newtonsoft.Json;
using SoapService.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace SoapService
{
    /// <summary>
    /// Summary description for CharacterSearchService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CharacterSearchService : System.Web.Services.WebService
    {
        string characterPath = @"C:\Users\ana\Desktop\Schemas\got.xml";
        string characterSearchTarget;
        private List<GameOfThronesCharacter> gameOfThronesCharacters;
        private GameOfThronesCharacter gameOfThronesCharacter;
        private List<GameOfThronesCharacter> returnCharacters = new List<GameOfThronesCharacter>();
        string continentPath = @"C:\Users\ana\Desktop\SoapService\SoapService\continent.xml";
        string continentSearchTarget;
        private List<GameOfThronesContinent> gameOfThronesContinents;
        private GameOfThronesContinent gameOfThronesContinent;

        [WebMethod]
        public List<GameOfThronesCharacter> SearchCharacters(string key, string value)
        {
            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("X-RapidAPI-Key", "e54a5c43fbmsh6558a281c8d635dp1fec2bjsn49b042ef2124");
                webClient.Headers.Add("X-RapidAPI-Host", "game-of-thrones1.p.rapidapi.com");
                var body = webClient.DownloadString("https://game-of-thrones1.p.rapidapi.com/Characters");
                gameOfThronesCharacters = JsonConvert.DeserializeObject<List<GameOfThronesCharacter>>(body);
            }

            var serializer = new XmlSerializer(typeof(List<GameOfThronesCharacter>));
            TextWriter writer = new StreamWriter(characterPath);
            serializer.Serialize(writer, gameOfThronesCharacters);
            writer.Close();

            XDocument document = XDocument.Load(characterPath);
            characterSearchTarget = "/ArrayOfGameOfThronesCharacter/GameOfThronesCharacter[contains(" + key + ", '" + value + "')]";
            var results = document.XPathSelectElements(characterSearchTarget);

            foreach (var result in results)
            {
                StringReader reader = new StringReader(result.ToString());
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(GameOfThronesCharacter));
                gameOfThronesCharacter = (GameOfThronesCharacter)xmlSerializer.Deserialize(reader);
                returnCharacters.Add(gameOfThronesCharacter);
            }

            return returnCharacters;
        }

        [WebMethod]
        public GameOfThronesContinent SearchContinent(string value)
        {
            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("X-RapidAPI-Key", "e54a5c43fbmsh6558a281c8d635dp1fec2bjsn49b042ef2124");
                webClient.Headers.Add("X-RapidAPI-Host", "game-of-thrones1.p.rapidapi.com");
                var body = webClient.DownloadString("https://game-of-thrones1.p.rapidapi.com/Continents");
                gameOfThronesContinents = JsonConvert.DeserializeObject<List<GameOfThronesContinent>>(body);
            }

            var serializer = new XmlSerializer(typeof(List<GameOfThronesContinent>));
            TextWriter writer = new StreamWriter(continentPath);
            serializer.Serialize(writer, gameOfThronesContinents);
            writer.Close();

            XDocument document = XDocument.Load(continentPath);
            continentSearchTarget = "/ArrayOfGameOfThronesContinent/GameOfThronesContinent[Name = '" + value + "']";
            var results = document.XPathSelectElements(continentSearchTarget);

            foreach (var result in results)
            {
                StringReader reader = new StringReader(result.ToString());
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(GameOfThronesContinent));
                gameOfThronesContinent = (GameOfThronesContinent)xmlSerializer.Deserialize(reader);
            }

            return gameOfThronesContinent;
        }
    }
}
