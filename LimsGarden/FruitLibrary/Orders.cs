using System;

namespace FruitLibrary 
{
    public class Orders  
    {
        public int customer_id { get; set; }
        public int location_id { get; set; }
        public int order_total { get; set; }
        public void ViewOrderHistory()
        {
            
        }
    }
}


// Construct a way to handle the order history for each individual customer
// Add up all of the prices and send to the customer
// Create a way to remove items that customer no longer wants