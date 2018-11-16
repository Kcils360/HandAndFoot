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
        public GameDeck Game { get; set; }
        public DiscardPile DiscardPile { get; set; }
        public List<Player> Players { get; set; }
    }
}
