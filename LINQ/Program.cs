using System;
using System.Collections.Generic;
using System.Linq;

// Build a collection of customers who are millionaires

public class Bank {
    public string Symbol { get; set; }
    public string Name { get; set; }
}

public class MillNumber {
    public string Bank { get; set; }
    public int NumberOfMillionaires { get; set; }

}
public class Customer {
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}

public class Program {
    public static void Main () {

        // Create some banks and store in a List
        List<Bank> banks = new List<Bank> () {
            new Bank () { Name = "First Tennessee", Symbol = "FTB" },
            new Bank () { Name = "Wells Fargo", Symbol = "WF" },
            new Bank () { Name = "Bank of America", Symbol = "BOA" },
            new Bank () { Name = "Citibank", Symbol = "CITI" },
        };

        List<Customer> customers = new List<Customer> () {
            new Customer () { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
            new Customer () { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
            new Customer () { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
            new Customer () { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
            new Customer () { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
            new Customer () { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
            new Customer () { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
            new Customer () { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
            new Customer () { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
            new Customer () { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
        };

        //Millionaires:
        IEnumerable<Customer> Millionaires = from c in customers
        where c.Balance >= 1000000
        //orderby c.Bank 
        select c;

        foreach (Customer c in Millionaires) {
            Console.WriteLine (c.Name);
        }

        /*
                  List<SalesReportEntry> salesReport = (from kid in kids
                     //dealing with kids list
                        group kid by kid.Neighborhood into neighborhoodGroup
                    //now dealing with neighborhoodGroup list
                        select new SalesReportEntry {
                            ReportNeighborhood = neighborhoodGroup.Key, 
                            ReportTotalSales = neighborhoodGroup.Sum(kidObj => kidObj.Sales)
                        }).OrderByDescending(sr => sr.ReportTotalSales).ToList();

                    foreach(SalesReportEntry entry in salesReport)
                    {
                        Console.WriteLine($"{entry.ReportNeighborhood}, {entry.ReportTotalSales}");
                    }
                 */
        List<MillNumber> millReport = (from c in customers 
        where c.Balance >= 1000000 
        group c by c.Bank into newGroupThing
        select new MillNumber {
                Bank = newGroupThing.Key,
                NumberOfMillionaires = newGroupThing.Count ()
        }).ToList();

        foreach(MillNumber entry in millReport)
        {
            Console.WriteLine(entry.Bank, entry.NumberOfMillionaires);
        }

            /*
                Given the same customer set, display how many millionaires per bank.
                Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
            */

            /* 
                    List<MillNumber> bankReport = (from c in customers 
                    where c.Balance >= 1000000
                    group c by c.Bank into newgroup
                    select new MillNumber {
                        report = newgroup.Key,
                        reportNumber = newgroup.Count(bkObj =>
                        bnkObj.Bank)
                    } ).OrderByDescending(s => .reportNumber.ToList();
                    


                    //foreach (Customer customer in bankReport) {
                        //Console.WriteLine ($"{customer.Name} at {customer.Bank}");
                    //}

                    /*
                        TASK:
                        As in the previous exercise, you're going to output the millionaires,
                        but you will also display the full name of the bank. You also need
                        to sort the millionaires' names, ascending by their LAST name.

                        Example output:
                            Tina Fey at Citibank
                            Joe Landy at Wells Fargo
                            Sarah Ng at First Tennessee
                            Les Paul at Wells Fargo
                            Peg Vale at Bank of America
                    */
                    while(true)
                    {
                        Console.Write("All work and no play makes Jack a dull boy");
                    }

        }
    }