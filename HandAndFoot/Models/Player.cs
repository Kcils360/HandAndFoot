using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string GameTableID { get; set; }
        public string Name { get; set; }
        public string Hand { get; set; }
        public string Foot { get; set; }
        public string Books { get; set; }
    }
}
