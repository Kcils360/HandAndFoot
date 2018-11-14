using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandAndFoot.Classes;

namespace HandAndFoot.Models
{
    public class PlayerViewModel : Player
    {
        public List<Card> _hand;
        public List<Card> _foot;
        public string _user;
    }
}
