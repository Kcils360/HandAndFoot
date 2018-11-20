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

        public string SerializeDiscard()
        {
            string discard = "";
            foreach (var c in Discards)
            {
                discard = discard + c.SerializeCard();
            }
            return "";
        }
    }
}
