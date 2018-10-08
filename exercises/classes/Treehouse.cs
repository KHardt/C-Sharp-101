using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            try{
                
            Console.Write("Enter the number of times to print \"Yay!\": ");
            string input = Console.ReadLine();
                
            int count = int.Parse(input);
                
            if (count <= 0) {
                Console.Write("You must enter a positive number");
            } else {
                
            int i = 0;
            while(i < count)
            {
                i += 1;   
                Console.WriteLine("Yay!");
            }
            }
             
    
            catch(FormatException) 
            {
                Console.Write("You must enter a whole number.");
            }
                
        
            
        }
    }
}
