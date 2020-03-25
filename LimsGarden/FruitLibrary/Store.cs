using System;

namespace FruitLibrary 
{
    public class Store  
    {
        
        public void ShopLocation()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Lim's Garden!");
            Console.WriteLine();
            Console.WriteLine("Please select a location below:");
            Console.WriteLine();
            Console.WriteLine("California");
            Console.WriteLine("Washington");
            Console.WriteLine("Texas");
            var response = Console.ReadLine();

        }
        public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Howdy!");
            Console.WriteLine();
            Console.WriteLine("How may we help you today?");
            Console.WriteLine();
            Console.WriteLine("To buy Fruit, press f");
            Console.WriteLine("To buy Vegetables, press v");
            Console.WriteLine("To buy A Plant, press p");
            string category = Console.ReadLine();

// Fruit Buying Options

            if(category == "f")
            {
                var ifFruit = new Fruit();
                ifFruit.FruitOptions();
            }

// Vegetable Buying Options
            
            else if(category == "v")
            {
                var ifVegetable = new Vegetable();
                ifVegetable.VegetableOptions();
            }

// Plant Buying Options
            
            else if(category == "p")
            {
                var ifPlant = new Tree();
                ifPlant.TreeOptions();
            }
             else
            {
                Console.WriteLine("Error: Please try again.");
            }
            
        }
    }
}
