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
                Console.WriteLine("Cucumber");
                Console.WriteLine("Asparagus");
                Console.WriteLine("Carrot");
                Console.WriteLine("Bell Pepper");
                string fruitChoice = Console.ReadLine();
                if(fruitChoice == "Cucumber")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Great! Your total is: ");
                }
                else if(fruitChoice == "Asparagus")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Great! Your total is: ");
                }
                else if(fruitChoice == "Carrot")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Great! Your total is: ");
                }
                else if(fruitChoice == "Bell Pepper")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Great! Your total is: ");
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