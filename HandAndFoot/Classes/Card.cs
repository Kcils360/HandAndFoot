using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Classes
{
    public class Card
    {
        public string Name { get; set; }
        public string Suite { get; set; }
        public int PointValue { get; set; }

        public Card(string n, string s, int p)
        {
            Name = n;
            Suite = s;
            PointValue = p;
        }
    }
}
