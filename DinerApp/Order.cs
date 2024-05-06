/* Order.cs
 * Date: 10/21/2023
 * Author: Jaren Montano
 * Purpose: this is to hold the data from the 
 * GUI of someones said order. Later if desire you could have
 * when an order is placed to send this to a database
 * and re clear, then pull back from the data base, or
 * have an arraylist that holds all of these 
 * order classes and populated them back into the
 * app.
 * 
 * 
 * Key Note: Dr. Fry's favorite sandwich is a Ruben.
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerApp
{
    public class Order
    {
        public string[] menuEntree = new string[]
        {
            "Chicken Salad",
            "Ham and Cheese",
            "Turkey",
            "Vegetable Wrap",
            "Tuna Salad",
            "Avacado and Cheese",
            "Club",
            "Peanut Butter & Jelly",
            "Grilled Cheese",
            "Ruben" // frys favorite
        };

        public decimal[] menuEntreePrice = new decimal[]
        {
            50m, 5.00m, 4.75m, 4.50m, 4.00m, 5.50m, 3.75m , 3.50m, 3.50m, 5.00m
        };

        public string Entree { get; set; }
        public bool WaterSelection { get; set; }
        public string DrinkSelection { get; set; }
        public string SpecialRequest { get; set; }
        public decimal EntreePrice { get; set; }
        public decimal DrinkPrice { get; set;}

        public Order()
        {
            Entree = string.Empty;
            WaterSelection = false; 
            SpecialRequest = string.Empty;
            DrinkPrice = 0;
            EntreePrice = 0;

        }

        //after the entree is selected, store the price
        public void SetEntreePrice()
        {
            for(int i = 0;i< menuEntree.Length; i++)
            {
                if (menuEntree[i] == Entree)
                {
                    EntreePrice= menuEntreePrice[i];
                }
            }
        }

        //Get the water selection 
        public string GetWaterSelection()
        {
            string waterOrNot;

            if (WaterSelection)
            {
                waterOrNot = "Water";
            }
            else
            {
                waterOrNot = "No Water";
            }
           
            return waterOrNot;

        }

        //drinks figuring it out
        public void SetDrinkPrice()
        {
            switch(DrinkSelection)
            {
                case "Tea":
                case "Coffee":
                    DrinkPrice = 1.50m;
                    break;

                case "Soda":
                case "Lemonade":
                    DrinkPrice = 2.00m;
                    break;
                case "Milk":
                case "Juice":
                    DrinkPrice = 1.75M;
                    break;
            }
            
        }

        // return total cost of the order
        public decimal DetermineTotalCharges()
        {
            SetDrinkPrice();
            SetEntreePrice();
            return EntreePrice + DrinkPrice;
        }


        public override string ToString()
        {
            return "Total Due: " +
                DetermineTotalCharges().ToString("C");
        }

    }
}
