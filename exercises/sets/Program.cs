using System;
using System.Collections.Generic;

namespace sets {
    class Program {
        static void Main (string[] args) {
            List<string> Inventory = new List<string> () {
                "Camry",
                "F-150",
                "MDX",
                "Camry",
                "Camry",
                "Taurus",
                "F-150",
                "MDX",
                "Camry",
                "Xterra",
                "Mustang",
                "Suburban",
                "Santa Fe",
                "F-150",
                "Camry",
                "F-150",
                "F-150",
                "Mustang",
                "Camry",
                "Camry",
                "Camry",
                "Escalade",
                "Q30",
                "Camry",
                "MDX",
            };

            HashSet<string> showRoom = new HashSet<string> ();

            showRoom.Add ("Camry");
            showRoom.Add ("MDX");
            showRoom.Add ("Q30");
            showRoom.Add ("Escalade");
            showRoom.Add ("Escalade");

            foreach (string vehicle in showRoom) {
                //Console.WriteLine($"{vehicle}");
            }

            int c = showRoom.Count; //counts the total in the array
            //Console.WriteLine (c); //if a dup added only 4 still since hash

            HashSet<string> usedLot = new HashSet<string> ();
            usedLot.Add ("F-150");
            usedLot.Add ("Taurus");

            showRoom.UnionWith (usedLot);
            foreach (string vehicle in showRoom) {
                //Console.WriteLine(vehicle);
            }

            showRoom.Remove ("F-150");

            foreach (string vehicle in showRoom) {
                //Console.WriteLine (vehicle);
            }

            //Aquiring more cars:

            HashSet<string> Junkyard = new HashSet<string> ();

            Junkyard.Add("Suburban");
            Junkyard.Add("Mustang");
            Junkyard.Add("Camry");
            Junkyard.Add("MDX");

            HashSet<string> showRoomclone = new HashSet<string>(showRoom);

            showRoomclone.IntersectWith(Junkyard);
            foreach (string vehicle in showRoomclone) {
                //Console.WriteLine (vehicle);
            }
            
            showRoom.UnionWith (Junkyard);
            
            foreach (string vehicle in showRoom) {
                //Console.WriteLine (vehicle);
            }

            showRoom.Remove("Mustang");//if you make this Junkyard.remove will not update showRoom. 
            foreach (string taco in showRoom) {
                Console.WriteLine (taco);
            }


        }
    }
}