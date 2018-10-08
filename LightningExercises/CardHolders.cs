using System;
using System.Collections.Generic;

namespace LightningExercises 
{
public class CardHolder
    {
        public string FullName {get; set; }

        public int Id {get; set; }

        private List<Book> CurrentBooks = new List<Book>();

        public void CheckOutBook(Book book) {
            CurrentBooks.Add(book);
        }
        

    }

}