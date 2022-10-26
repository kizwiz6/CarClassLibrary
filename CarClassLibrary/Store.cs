using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarList { get; set; } // catalogue of everything that can be bought in store.
        public List<Car> ShoppingList { get; set; } // cart.


        public Store()
        {
            CarList = new List<Car>(); // CarList is new list of type Car.
            ShoppingList = new List<Car>(); // New type of list and it will be empty ()
        }

        // Methods (actions of the class)
        /// <summary>
        /// Look at all the cars in the shopping list and return the total cost to whatever function calls it (hence the return value of Decimal.
        /// </summary>
        /// <returns>Decimal</returns>
        public decimal Checkout()
        {
            // Initialise the total cost
            decimal totalCost = 0;

            foreach (var c in ShoppingList)
            {
                totalCost += c.Price; // += compound assignment - aggregates and adds on the total cost.
            }
            ShoppingList.Clear(); // since checking out need to empty whatever is in the list = no cars anymore
            return totalCost;
        }
    }
}
