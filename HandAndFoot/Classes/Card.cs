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

        
    }
}
