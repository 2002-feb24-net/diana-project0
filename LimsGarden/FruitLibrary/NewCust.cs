using System;
using DataBaseConnection.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;



namespace FruitLibrary
{
    public class NewCust
    {
        public string first_name { get; set; }
        public string last_name { get; set;}

        public void CustomerName()
        {
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("To complete your order, please complete the fields below:");
            Console.WriteLine();
            Console.WriteLine("Enter first name here:");
            first_name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter last name here:");
            last_name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter street address here:");
            string addresss = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter city here:");
            string addy = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter state here:");
            string cali = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter zipcode here:");
            string zip = Console.ReadLine();

       /*   using (var context = new LimsGardenContext())
            {
                //int NewCustId;
                //try
                //{
                //    NewCustId = context.Customer.Max(p => p.CustomerId)+1;
                //}
                //catch
                //{
                //    NewCustId = 1;
                //}
                var newCustomer = new Customer
                {
                    FirstName = first_name,
                    LastName = last_name
                };
                context.Customer.Add(newCustomer);
                context.SaveChanges();
            }
               */     

        }

        public void Thankyou()
        {
            Console.Clear();
            Console.WriteLine("Thank you, Diana Lim.");
            Console.WriteLine();
            Console.WriteLine("Your order is complete!");
        }
        
        
    }
}
