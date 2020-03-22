using System;

namespace FruitLibrary 
{
    public class Vegetable: Plant  
    {
        public Vegetable(string vName, int vPrice) 
        {
            this.name = vName;
            this.price = vPrice;
        }
        public void VegetableOptions()
        {
        }
    }
}