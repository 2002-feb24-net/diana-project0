using System;

namespace FruitLibrary 
{
    public class Vegetable: Plant  
    {
       
        public void VegetableOptions()
        {
                Console.Clear();
                Console.WriteLine("What kind of vegetable would you like to buy?");
                Console.WriteLine();
                Console.WriteLine("Cucumber $1");
                Console.WriteLine("Asparagus $3");
                Console.WriteLine("Carrot $1");
                Console.WriteLine("Bell Pepper $1");
                string fruitChoice = Console.ReadLine();
                if(fruitChoice == "Cucumber")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Your total is: $5");
                    Console.ReadLine();
                }
                else if(fruitChoice == "Asparagus")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Your total is: $15");
                    Console.ReadLine();
                }
                else if(fruitChoice == "Carrot")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Your total is: $5");
                    Console.ReadLine();
                }
                else if(fruitChoice == "Bell Pepper")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Your total is: $5");
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