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

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
            Dictionary<string, string> probeObj = new Dictionary<string, string>();
            probeObj.Add("Mars", "Viking");
            probes.Add(probeObj);
            //foreach(KeyValuePair<string, string> probeObj in probes)
            {
           // Console.WriteLine($"We sold {probes.Value} units of {probes.Key}");
            }
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

 
 