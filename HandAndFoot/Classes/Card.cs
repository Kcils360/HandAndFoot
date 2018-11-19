using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Classes
{
    public class Card
    {
        public string Name { get; set; }
        public string Suit { get; set; }
        public string PointValue { get; set; }

        public Card(string n, string s, string p)
        {
            Name = n;
            Suit = s;
            PointValue = p;
        }

        public string SerializeCard()
        {
            string name = JsonConvert.SerializeObject(Name);
            string suit = JsonConvert.SerializeObject(Suit);
            string points = JsonConvert.SerializeObject(PointValue);
            string card ="["+ name + suit + points +"]";
            return card;
        }
    }
}
