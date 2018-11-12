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
    }
}
