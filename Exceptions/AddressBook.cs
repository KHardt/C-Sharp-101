using System;
using System.Collections.Generic;



namespace exceptions {
public class AddressBook {



        Dictionary<string, Contact> addressbook = new Dictionary<string, Contact> ();


         public void AddContact (Contact contact){

                 try{
            addressbook.Add(contact.Email, contact);
                 }
                catch (ArgumentException ex) 
                {
                Console.WriteLine($"This user was already added: {contact.Email}", ex);
                }
    }


     public Contact GetByEmail(string email) {
        
                
            return addressbook[email];
                
               
        }

}

}