using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/RestService.Model")]
    internal class GameOfThronesCharacter
    {
        private static int id = 54;

        [DataMember(Order = 0)]
        public int Id { get; set; }

        [DataMember(Order = 1)]
        public string FirstName { get; set; }

        [DataMember(Order = 2)]
        public string LastName { get; set; }

        [DataMember(Order = 3)]
        public string FullName { get; set; }

        [DataMember(Order = 4)]
        public string Title { get; set; }

        [DataMember(Order = 5)]
        public string Family { get; set; }

        [DataMember(Order = 6)]
        public string Image { get; set; }

        [DataMember(Order = 7)]
        public string ImageUrl { get; set; }

        public GameOfThronesCharacter(int id, string firstName, string lastName, string fullName, string title, string family, string image, string imageUrl)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Title = title;
            Family = family;
            Image = image;
            ImageUrl = imageUrl;
        }

        public GameOfThronesCharacter(string firstName, string lastName, string fullName, string title, string family, string image, string imageUrl)
        {
            Id = id++;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Title = title;
            Family = family;
            Image = image;
            ImageUrl = imageUrl;
        }

        public GameOfThronesCharacter()
        {
        }

        public override string ToString()
        {
            return $"{FullName} of the {Family}, holds title {Title}";
        }
    }
}
