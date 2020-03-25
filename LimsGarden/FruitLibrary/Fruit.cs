using System;

namespace FruitLibrary 
{
    public class Fruit: Plant  
    {      
        public void FruitOptions()
        {
                Console.Clear();
                Console.WriteLine("What kind of fruit would you like to buy?");
                Console.WriteLine();
                Console.WriteLine("Watermelon $5");
                Console.WriteLine("Nectarine $1");
                Console.WriteLine("Loquat $1");
                Console.WriteLine("Asian Apple $2");
                string fruitChoice = Console.ReadLine();
                if(fruitChoice == "Watermelon")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Your total is: $25");
                    Console.ReadLine();
                }
                else if(fruitChoice == "Nectarine")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Your total is: $5");
                    Console.ReadLine();
                }
                else if(fruitChoice == "Loquat")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Your total is: $5");
                    Console.ReadLine();
                }
                else if(fruitChoice == "Asian Apple")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Your total is: $10");
                    Console.ReadLine();
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Error: Please check item name spelling, and try again.");
                    // Create a way to return to beginning of fruit prompt
                }
        }
        
    }

}