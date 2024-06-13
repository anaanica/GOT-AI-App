using RestService.Model;
using System.Xml.Linq;

namespace RestService.Utils
{
    public class XmlHandler
    {
        public string getCharacterXML()
        {
            string path = Path.Combine(Environment.CurrentDirectory, Constants.xmlPath);
            return XDocument.Load(path).ToString();
        }
    }
}
