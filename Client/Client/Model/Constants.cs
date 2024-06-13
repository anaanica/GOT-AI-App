using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Constants
    {
        public const string XSD = "XSD";
        public const string RNG = "RNG";
        public const string postXSDValidationEndpoint = "http://localhost:5000/api/Got/XSD";
        public const string postRNGValidationEndpoint = "http://localhost:5000/api/Got/RNG";
        public const string allFieldsRequired = "all fields required";
        public const string validationPassed = "validation passed";
        public const string validationFailed = "validation failed";
        public const string badRequest = "400 bad request";
        public const string postMethod = "POST";
        public const string json = "application/json";
        public const string xml = "application/xml";
        public const string firstName = "FirstName";
        public const string lastName = "LastName";
        public const string fullName = "FullName";
        public const string title = "Title";
        public const string family = "Family";
        public const string noMatch = "no matching result found";
        public const string gotContinentsUri = "https://game-of-thrones1.p.rapidapi.com/Continents";
        public const string gotCharactersUri = "https://game-of-thrones1.p.rapidapi.com/Characters";
        public const string gptUri = "https://open-ai21.p.rapidapi.com/conversationgpt35";
    }
}
