using System;
using System.Collections.Generic;

namespace lists
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> planetList2 = new List<string>(){"Neptune", "Uranus"};
            //planetList.ForEach(pl2 => Console.WriteLine(pl2));
            planetList.AddRange(planetList2);
            planetList.Insert(0, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");
            List<string> rockyPlanets = new List<string>(){};
            rockyPlanets = planetList.GetRange(0, 4);
            //planetList.ForEach(pl2 => Console.WriteLine(pl2));
            //rockyPlanets.ForEach(rp => Console.WriteLine(rp));

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>(); //list of dictionaries
            Dictionary<string, string> Viking = new Dictionary<string, string>() ;
            Dictionary<string, string> Mariner10 = new Dictionary<string, string>() ;
            Dictionary<string, string> Voyager1 = new Dictionary<string, string>() ;

            Viking.Add("Mars", "Viking");
            Mariner10.Add("Venus", "Mariner10");
            Voyager1.Add("Jupiter", "Voyager1");
            probes.Add(Viking);
            probes.Add(Mariner10);
            probes.Add(Voyager1);


foreach (KeyValuePair<string, string> kvp in Viking)
{ //how to go over all the stuff in probes in no particular order?
    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}
      
           //probes.ForEach(pl2 => Console.WriteLine(Key: {0} Value: {1}));
        
        foreach (string planet in planetList) {
              List<string> visitedProbes = new List<string>();
               foreach (Dictionary<string, string> probe in probes) {
                    if (probe.ContainsKey(planet)) {
                        visitedProbes.Add(probe[planet]);
                    }
               }
                 if(visitedProbes.Count > 0) {
                    //Console.WriteLine($"{planet}: {String.Join(", ", visitedProbes)}");
                }
        }


        

            //foreach(KeyValuePair<string, string> probeObj in probes)
            
           // Console.WriteLine($"We sold {probes.Value} units of {probes.Key}");
            
            //probes.ForEach(stu => Console.WriteLine(stu));
        
            
            //Console.WriteLine($"{probes[0]}");

            //probes.Add();
            //probes[0]["Mars"] = "Viking"; //index out of bounds

            
            //foreach (List<string> i in planetList) 
            //{
                //Console.WriteLine(i);
           // }
            //probes.ForEach(pr => Console.WriteLine(pr));
        }
        
    }
}

 
 