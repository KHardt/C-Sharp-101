using System;
using System.Collections.Generic;


namespace LightningExercises {
    public class Library {

        private List<Book> BookList = new List<Book>(); //this way creates a new list. shorter version won't make the list yet.
        //Actually use the Book class!


        public string Address { get; set; }

        public string Name { get; set; }

        public void AddBook(Book bk)
        {
            BookList.Add(bk);
        }
    }

}

/*
Make a Library class that has:
- Private List of Books (remember casing and naming convention here)
- Public Method to add a Book to the List of Books
- Public Address property
- Public Name property
 

 */