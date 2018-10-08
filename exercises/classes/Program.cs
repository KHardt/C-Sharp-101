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

        public string Title { get; }

        public DateTime StartDate { get; }

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
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public void ListEmployees(Employee employee)
         {
            Console.WriteLine($"Employee name {employee.FullName}");
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
    }

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.

            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }

}