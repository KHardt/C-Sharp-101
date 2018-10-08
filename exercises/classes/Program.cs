using System;
using System.Collections.Generic;

namespace ClassesInStuff {

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.
            DateTime companyStart = new DateTime(2015, 1, 18);
            Company KlausMart = new Company ("KlausMart", companyStart){ };
            Console.Write(KlausMart.CreatedOn);

            DateTime employeeStart = new DateTime(2016, 3, 17 );
            DateTime employeeStart2 = new DateTime(2017, 7, 1 );
            Employee Jake = new Employee () {
                firstName = "Jake",
                lastName = "Dullom",
                Title = "clerk",
                StartDate = employeeStart

            };

            Employee Jim = new Employee () {
                firstName = "Jim",
                lastName = "Bob",
                Title = "specialist",
                StartDate = employeeStart

            };

            Employee Kirk = new Employee () {
                firstName = "James",
                lastName = "Kirk",
                Title = "commander",
                StartDate = employeeStart2

            };

            //EmployeeList.Add 
            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }

}