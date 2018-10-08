using System;
using System.Collections.Generic;

namespace LightningExercises
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Library KlausLib = new Library()
            {
                Name = "Klaus Library",
                Address= "House Street"
            };

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

            KlausLib.AddBook(UnicornFace);
            KlausLib.AddBook(CamelFace);
            KlausLib.AddBook(ElephantFace);
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