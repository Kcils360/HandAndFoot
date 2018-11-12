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
        public GameTable(GameDeck gd, DiscardPile dp)
        {
            GameDeck = gd;
            DiscardPile = dp;
        }

        //Gameplay Methods
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
