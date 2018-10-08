using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, string> stocks = new Dictionary<string, string> ();
            stocks.Add ("GM", "General Motors");
            stocks.Add ("CAT", "Caterpillar");
            stocks.Add ("COKE", "Coca-Cola Bottling");
            stocks.Add ("TBS", "Turner Broadcasting Corp");

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>> ();

            purchases.Add (new Dictionary<string, double> () { { "GM", 230.21 } });
            purchases.Add (new Dictionary<string, double> () { { "CAT", 580.98 } });
            purchases.Add (new Dictionary<string, double> () { { "COKE", 300.34 } });
            purchases.Add (new Dictionary<string, double> () { { "TBS", 406.34 } });

            //foreach (KeyValuePair<string, string> kvp in stocks) { //how to go over all the stuff in probes in no particular order?
                //Console.WriteLine ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}

            Dictionary<string, double> stockReport = new Dictionary<string, double> ();


            foreach (Dictionary<string, double> purchase in purchases) {
                foreach (KeyValuePair<string, double> transaction in purchase) {
                    string fullCompanyName = stocks[transaction.Key]; //AAPL

                    if (stockReport.ContainsKey (fullCompanyName)) {
                        // stockReport[fullCompanyName] += transaction.Value;
                        stockReport[fullCompanyName] = stockReport[fullCompanyName] + transaction.Value;
                    } else {
                        // stockReport.Add(fullCompanyName, transaction.Value);
                        stockReport[fullCompanyName] = transaction.Value;
                    }
                }
            }

             foreach (KeyValuePair<string, double> valuation in stockReport)
            {
                Console.WriteLine($"{valuation.Key} has a valuation of {valuation.Value.ToString("C")}");
            }

        }
    }
}