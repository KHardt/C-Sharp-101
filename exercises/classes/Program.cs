using System;
using System.Collections.Generic;

namespace classes {
    public class Employee {
        public string firstName;
        public string lastName;
        

        public string FirstName {
            get {
                return firstName;
            }
            set {
                firstName = value;
            }
        }

        public string LastName {
            get {
                return lastName;
            }
            set {
                lastName = value;
            }
        }

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

    public class Company {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set;}
        public DateTime CreatedOn { get; set;}

        // Create a public property for holding a list of current employees
        
            //Console.WriteLine($"Employee name {employee.FullName}");
        
        List<string> EmployeeList = new List<string>();

        
        //EmployeeList.ForEach(pl2 => Console.WriteLine(pl2));
            
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
 
   
            The constructor will set the value of the public properties
        */

        public Company(string CompanyName, DateTime DateCreated)
        {
            Name=CompanyName;
            CreatedOn=DateCreated;
        }

        
    }

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.

            Company KroMart = new Company() 
            {
                Name = "KroMart",
                CreatedOn= "";
            };

            Employee NewGroup = new Employee()
            {
                FullName: "Jim",

            };

            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }

    

}