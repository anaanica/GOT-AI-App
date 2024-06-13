using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    [DataContract]
    internal class GameOfThronesContinent
    {
        [DataMember(Order = 0)]
        public int Id { get; set; }

        [DataMember(Order = 1)]
        public string Name { get; set; }

        public GameOfThronesContinent(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public GameOfThronesContinent()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
