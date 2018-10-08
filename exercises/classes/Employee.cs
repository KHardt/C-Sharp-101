 using System;
 
namespace ClassesInStuff {
 public class Employee {
        public string firstName {get; set;}
        public string lastName {get; set;}
        
        public string Title { get; set;}

        public DateTime StartDate { get; set;}

        public string FullName
        {
            get
            {
                return string.Format($"{firstName} {lastName}");
            }
        }


    }

}