using System;
using System.Collections.Generic;

namespace FruitLibrary 
{
    public abstract class Location  
    {
        public virtual string branch_name { get; set; }
        public virtual string street_address1 { get; set; }
        public virtual string street_address2 { get; set; }
        public virtual string city { get; set; }
        public virtual string state_name { get; set; }
        public int zipcode { get; set; }


       // public virtual List<Plant> inventory { get; set;}

       // public virtual int Sold();
       // {

        //} 
        // I want to know which item in List I am working with
        // I want to receive the true or false value of whether or not they want to buy the plant
        // I want to get user input for how many items they want to buy
        // I want to add up the price total and send it to the Order class


    }
}