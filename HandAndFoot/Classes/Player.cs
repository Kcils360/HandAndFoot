using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Classes
{
    public class Player
    {
        public Player()
        {

        }
        //player will have:
        // Hand List<book>
        // Foot List<book>
        // Table List<book>
        // GameID - When game is created, an ID is assigned.  This will allow players to access the game session.
        // Extras
        // Current Hand will display Hand until empty then foot
        // Name
        // point total
        // books 3,4,5,6,7,8,9,10,J,Q,K,A, W
        // when books in hand have 3 cards, move to table
        // when books on table have 7, close and total points
        public string Name { get; set; }
        public Hand Hand { get; set; }
        public Hand Foot { get; set; }
        public List<Book> LayOnTable { get; set; }
        public int PlayerID { get; set; }
        public string GameID { get; set; }
        public Player(List<Card> hand, List<Card> foot, string name)
        {
            Name = name;
            Hand = new Hand(hand);
            Foot = new Hand(foot);
        }

        public void LayDown(List<Card> c)
        {
            Book B = new Book(new List<Card>());
            foreach (var card in c)
            {
                B.BookOfCards.Add(card);
            }
            LayOnTable.Add(B);
        }
    }
}
