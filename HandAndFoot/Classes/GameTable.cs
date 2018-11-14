using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Classes
{
    public class GameTable
    {
        // Will be displayed on every turn, shows all Tables from each player and the top of the discard pile

        public GameDeck GameDeck { get; set; }
        public DiscardPile DiscardPile { get; set; }
        public List<Player> Players { get; set; }
        public int GameID { get; set; }
        public GameTable(GameDeck gd, DiscardPile dp)
        {
            GameDeck = gd;
            DiscardPile = dp;
        }

        //Gameplay Methods
        public string MakeNewGameId()
        {
            //var letters = new Alphabet();
            var letters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "N", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };

            var random = new Random();
            string GameId = "";

            for (int j = 0; j < 10; j++)
            {
                var randomIndex = random.Next(0, letters.Length);
                GameId += letters[randomIndex];
            }
            return GameId;
        }

        public void ShowDiscard()
        {
            Console.WriteLine("Top Card in Discard");
            Console.WriteLine(DiscardPile.Discards[0].Name);
        }

        public void Discard(Player p, string n)
        {
            foreach (var c in p.Hand.Cards)
            {
                if (c.Name == n)
                {
                    p.Hand.Cards.Remove(c);
                    DiscardPile.Discards.Add(c);
                    break;
                }
            }
        }

        public void TakePile(Player p)
        {
            int c = DiscardPile.Discards.Count;
            for (var i = 0; i < c; i++)
            {
                p.Hand.Cards.Add(DiscardPile.Discards[0]);
                DiscardPile.Discards.Remove(DiscardPile.Discards[0]);

            }
        }

        public void Draw2(Player p)
        {

            for (var i = 0; i < 2; i++)
            {
                p.Hand.Cards.Add(GameDeck.Cards[0]);
                GameDeck.Cards.Remove(GameDeck.Cards[0]);

            }
        }

        public void SortHand(Player p)
        {
            var Result = new List<Card>();
            var r = p.Hand.Cards.OrderBy(c => c.Name).OrderBy(v => v.PointValue);
            foreach (var c in r)
            {
                Result.Add(c);
            }
            p.Hand.Cards = Result;
        }
    }
}
