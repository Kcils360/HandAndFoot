using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Classes
{
    public class DiscardPile
    {
        public List<Card> Discards { get; set; }
        public DiscardPile(List<Card> discards)
        {
            Discards = discards;
        }

    }
}
