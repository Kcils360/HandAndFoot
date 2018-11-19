using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Classes
{
    public class GameDeck
    {
        public List<Card> Cards { get; set; }
        public GameDeck()
        {
            List<Card> gameDeck = new List<Card>();
            Deck Deck1 = Shuffle(new Deck(new List<Card>()));
            InsertCards(Deck1, gameDeck);
            Deck Deck2 = Shuffle(new Deck(new List<Card>()));
            InsertCards(Deck2, gameDeck);
            Deck Deck3 = Shuffle(new Deck(new List<Card>()));
            InsertCards(Deck3, gameDeck);
            Deck Deck4 = Shuffle(new Deck(new List<Card>()));
            InsertCards(Deck4, gameDeck);
            Cards = gameDeck;
        }
        private List<Card> InsertCards(Deck D, List<Card> L)
        {
            foreach (var c in D.Cards)
            {
                L.Add(c);
            }
            return L;
        }

        private Deck Shuffle(Deck D)
        {
            Random rand = new Random();

            List<Card> Temp = new List<Card>();
            int c = D.Cards.Count;

            while (c > 0)
            {
                var t = D.Cards[rand.Next(c)];
                Temp.Add(t);
                D.Cards.Remove(t);
                c--;
            }
            foreach (var d in Temp)
            {
                D.Cards.Add(d);
            }

            return D;

        }

        public List<Card> Deal(List<Card> set)
        {
            for (var i = 0; i <= 10; i++)
            {
                set.Add(Cards[i]);
                Cards.Remove(Cards[i]);
            }
            return set;
        }

        public string SerializeDeck()
        {
            string deck = "";
            foreach(var c in Cards)
            {
                deck = deck + c.SerializeCard() + " ";
            }
            
            return deck;
        }
    }
}
