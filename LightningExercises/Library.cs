using System;
using System.Collections.Generic;

namespace LightningExercises {
    public class Library {

        public Library (List<Book> initialInventory, string name, string address) //constructor. Has to be same name as class. Nothing after public
        {
            BookList = initialInventory;
            Name = name;
            Address = address;
        }

        private List<Book> BookList = new List<Book> (); //this way creates a new list. shorter version won't make the list yet.
        //Actually use the Book class!

        public string Address { get; set; }

        public string Name { get; set; }

        public void AddBook (Book bk) {
            BookList.Add (bk);
        }

        public void CheckOut (string isbn, CardHolder cardHolder) {
        
            
            foreach (Book book in BookList) 
            {
                if (book.ISBN == isbn && book.isAvailable == true) 
                {
                    cardHolder.CheckOutBook(book);
                    book.isAvailable = false;
                } 
                    
                
            }

        
        }

        public bool isAvailable(string isbn) //what if it's not in there. Makes you deal with it NOW!
        {
            foreach(Book book in BookList)
            {
                if (book.ISBN == isbn) {
                    return book.isAvailable;
                    
                } 

            }
            return false;
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