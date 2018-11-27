using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Classes
{
    public class Serializer
    {
        public string SerializeCard(Card C)
        {
            string name = JsonConvert.SerializeObject(C.Name);
            string suit = JsonConvert.SerializeObject(C.Suit);
            string points = JsonConvert.SerializeObject(C.PointValue);
            string card = "[" + name + suit + points + "]";
            return card;
        }

        public string SerialzeBook(Book B)
        {
            string book = "";
            foreach (var b in B.BookOfCards)
            {
                book = book + SerializeCard(b) + " ";
            }
            return book;
        }

        public string SerializeDeck(GameDeck D )
        {
            string deck = "";
            foreach (var c in D.Cards)
            {
                deck = deck + SerializeCard(c) + " ";
            }

            return deck;
        }

        public string SerializeHand(Hand H)
        {
            string hand = "";
            foreach (var c in H.Cards)
            {
                hand = hand + SerializeCard(c);
            }
            return "";
        }

        public string SerializePlayer(Player P)
        {
            string name = JsonConvert.SerializeObject(P.Name);
            string hand = SerializeHand(P.Hand);
            string foot = SerializeHand(P.Foot);
            string gameId = JsonConvert.SerializeObject(P.GameID);
            string book = "";
            foreach (var b in P.LayOnTable)
            {
                book = book + SerialzeBook(b) + " ";
            }
            string player = "[" + name + hand + foot + gameId + book + "]";

            return player;
        }

        public string SerializeDiscard(DiscardPile D)
        {
            string discard = "";
            foreach (var c in D.Discards)
            {
                discard = discard + SerializeCard(c);
            }
            return "";
        }

        public string SerializeGameTable(GameTable T)
        {
           
            return "";
        }
    }
}
