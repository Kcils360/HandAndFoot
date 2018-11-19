using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandAndFoot.Classes;

namespace HandAndFoot.Models
{
    public class GameTable
    {
        public int ID { get; set; }
        public string GameTableID { get; set; }
        public string GameDeck { get; set; }
        public string DiscardPile { get; set; }
        public string PlayersList { get; set; }
    }
}
