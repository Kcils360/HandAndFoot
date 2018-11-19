using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Classes
{
    public class Book
    {
        public List<Card> BookOfCards { get; set; }
        public Book(List<Card> book)
        {
            BookOfCards = book;
        }

        public string SerialzeBook()
        {
            string book = "";
            foreach (var b in BookOfCards)
            {
                book = book + b.SerializeCard() + " ";
            }
            return book;
        }
    }
}
