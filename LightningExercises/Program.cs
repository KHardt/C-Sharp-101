using System;
using System.Collections.Generic;

namespace LightningExercises
{
    
   class Program
    {
        static void Main(string[] args)
        {

            Book CamelFace = new Book()
            {
                Title = "Camel Face",
                Author = "Camel Man",
                ISBN = "hj4h55"
            };

            Book UnicornFace = new Book()
            {
                Title = "Unicorn Face",
                Author = "Camel Man",
                ISBN = "hj4h66"
            };

            Book ElephantFace = new Book()
            {
                Title = "Elephant Face",
                Author = "Joe Man",
                ISBN = "hj4h77"
            };

            
            List<Book> books = new List <Book>()
            {CamelFace}; 

            Library KlausLib = new Library(books, "Klaus Library", "House Street")
            {
            };

            KlausLib.AddBook(UnicornFace);
            KlausLib.AddBook(CamelFace);
            KlausLib.AddBook(ElephantFace);
            Console.Write(KlausLib);

        }
    }
}

 


/*
:zap:
```Create a few (4 or so) instances of Book and use the method on your Library class to add them to the list of books in an instance of Library```

1. Create a new Library instance
2. Create a bunch of Book instances
3. Use the method on your Library instance (that you made first) to add the instances of Book to the _bookList field (edited)
 */