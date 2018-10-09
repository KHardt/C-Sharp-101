using System;
using System.Collections.Generic;



namespace exceptions {
class AddressBook {



        public string FirstName {get; set;}

        public string LastName {get; set;}
        public string Email {get; set;}
        
        public string Address { get; set;}

        public void AddContact (Contact name, AddressBook book) {
            book.AddContact(name);
    }


}

}