using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, string> stocks = new Dictionary<string, string> ();
            stocks.Add ("GM", "General Motors");
            stocks.Add ("CAT", "Caterpillar");
            stocks.Add("COKE", "Coca-Cola Bottling");
            stocks.Add("TBS", "Turner Broadcasting Corp");
            //string GM = stocks["GM"];
            Dictionary<string, double> purchases = new Dictionary<string, double>();
            purchases.Add("GE", 230.21);
            //list of dictionaries
            //purchases.Add("GE", 580.98);
            //purchases.Add("GE", 406.34);
            if (purchases.ContainsKey("GE"))
            {

                 Console.WriteLine(purchases);
            }

           
            Dictionary<string, double> stockReport = new Dictionary<string, double>();

        }
    }
}