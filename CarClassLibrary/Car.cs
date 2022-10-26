using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; } // 2 decimal places are recommended for currency.
        public string Colour { get; set; }
        public int Year { get; set; }
        public int Miles { get; set; }
        public bool IsNew { get; set; }
        public decimal SizeOfEngine { get; set; }
        public int BodyCondition { get; set; } // ranking from 1 to 10

        /// <summary>
        /// Default paramaterless constructor.
        /// </summary>
        public Car()
        {
            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
        }

        /// <summary>
        /// Parameterised constructor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Car(string a, string b, decimal c)
        {
            Make = a;
            Model = b;
            Price = c;
        }

        public Car(string make, string model, string colour, int year, bool isnew, int miles, decimal sizeOfEngine, int bodyCondition)
        {
            this.Make = make;
            this.Model = model;
            this.Colour = colour;
            this.Year = year;
            this.IsNew = isnew;
            this.Miles = miles;
            this.SizeOfEngine = sizeOfEngine;
            this.BodyCondition = bodyCondition;
        }

        /// <summary>
        /// Overrides implementation of a class to simplify the print inventory command.
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return "Make: " + Make + " Model: " + Model + " Price: $" + Price;
        }

    }
}
