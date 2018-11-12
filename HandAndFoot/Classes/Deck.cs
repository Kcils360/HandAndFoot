using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Classes
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        public Deck(List<Card> cards)
        {

            cards.Add(new Card("2", Diamd.ToString(), 20));
            cards.Add(new Card("2", Heart.ToString(), 20));
            cards.Add(new Card("2", Clubs.ToString(), 20));
            cards.Add(new Card("2", Spade.ToString(), 20));
            cards.Add(new Card("3", Diamd.ToString(), 500));
            cards.Add(new Card("3", Heart.ToString(), 500));
            cards.Add(new Card("3", Clubs.ToString(), 300));
            cards.Add(new Card("3", Spade.ToString(), 300));
            cards.Add(new Card("4", Diamd.ToString(), 5));
            cards.Add(new Card("4", Heart.ToString(), 5));
            cards.Add(new Card("4", Clubs.ToString(), 5));
            cards.Add(new Card("4", Spade.ToString(), 5));
            cards.Add(new Card("5", Diamd.ToString(), 5));
            cards.Add(new Card("5", Heart.ToString(), 5));
            cards.Add(new Card("5", Clubs.ToString(), 5));
            cards.Add(new Card("5", Spade.ToString(), 5));
            cards.Add(new Card("6", Diamd.ToString(), 5));
            cards.Add(new Card("6", Heart.ToString(), 5));
            cards.Add(new Card("6", Clubs.ToString(), 5));
            cards.Add(new Card("6", Spade.ToString(), 5));
            cards.Add(new Card("7", Diamd.ToString(), 5));
            cards.Add(new Card("7", Heart.ToString(), 5));
            cards.Add(new Card("7", Clubs.ToString(), 5));
            cards.Add(new Card("7", Spade.ToString(), 5));
            cards.Add(new Card("8", Diamd.ToString(), 5));
            cards.Add(new Card("8", Heart.ToString(), 5));
            cards.Add(new Card("8", Clubs.ToString(), 5));
            cards.Add(new Card("8", Spade.ToString(), 5));
            cards.Add(new Card("9", Diamd.ToString(), 10));
            cards.Add(new Card("9", Heart.ToString(), 10));
            cards.Add(new Card("9", Clubs.ToString(), 10));
            cards.Add(new Card("9", Spade.ToString(), 10));
            cards.Add(new Card("10", Diamd.ToString(), 10));
            cards.Add(new Card("10", Heart.ToString(), 10));
            cards.Add(new Card("10", Clubs.ToString(), 10));
            cards.Add(new Card("10", Spade.ToString(), 10));
            cards.Add(new Card("J", Diamd.ToString(), 10));
            cards.Add(new Card("J", Heart.ToString(), 10));
            cards.Add(new Card("J", Clubs.ToString(), 10));
            cards.Add(new Card("J", Spade.ToString(), 10));
            cards.Add(new Card("Q", Diamd.ToString(), 10));
            cards.Add(new Card("Q", Heart.ToString(), 10));
            cards.Add(new Card("Q", Clubs.ToString(), 10));
            cards.Add(new Card("Q", Spade.ToString(), 10));
            cards.Add(new Card("K", Diamd.ToString(), 10));
            cards.Add(new Card("K", Heart.ToString(), 10));
            cards.Add(new Card("K", Clubs.ToString(), 10));
            cards.Add(new Card("K", Spade.ToString(), 10));
            cards.Add(new Card("A", Diamd.ToString(), 20));
            cards.Add(new Card("A", Heart.ToString(), 20));
            cards.Add(new Card("A", Clubs.ToString(), 20));
            cards.Add(new Card("A", Spade.ToString(), 20));
            cards.Add(new Card("jkr", "", 50));
            cards.Add(new Card("jkr", "", 50));

            Cards = cards;
        }

        Emoji Spade = new Emoji(0x2660);
        Emoji Heart = new Emoji(0x2665);
        Emoji Diamd = new Emoji(0x2666);
        Emoji Clubs = new Emoji(0x2663);
    }
}
