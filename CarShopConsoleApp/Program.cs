using CarClassLibrary;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();


            // WElcome message
            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            // Action
            int action = chooseAction();

            // When we're done with the loop we'll be done with the program
            // Type in 0 to end the program.
            while (action != 0)
            {
                Console.WriteLine("You chose " + action);

                // switch case statement to do different actions.
                // Will handle a variety of cases.
                switch (action)
                {
                    // Add item to inventory
                    case 1:
                        Console.WriteLine("You chose to add a new car to the inventory.");

                        String carMake = "";
                        String carModel = "";
                        Decimal carPrice = 0;

                        Console.WriteLine("What is the car make? ford, gm, nissan etc.");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? corvette, focus, ranger etc.");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car price?");
                        carPrice = int.Parse(Console.ReadLine()); // this will break if the user puts in letters.

                        Car newCar = new Car(carMake, carModel, carPrice);
                        // now need to add the car to the store:
                        s.CarList.Add(newCar);

                        printInventory(s);
                        break;

                    // Add to cart
                    case 2:

                        Console.WriteLine("You chose to add a car to the shopping cart.");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to buy? (number)");
                        int carChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.CarList[carChosen]); // from carlist add to the shopping list

                        printShoppingCart(s);
                        break;

                    default:
                        break;
                }


                action = chooseAction(); // ask for a new action - gives another chance to break out the loop
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Pritns everything in the shopping cart.
        /// </summary>
        /// <param name="s"></param>
        private static void printShoppingCart(Store s)
        {
            // Prints everything in the store
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("Cars you have chosen to buy");
                Console.WriteLine("Car # : " + i + " " + s.ShoppingList[i]); // i is the item number for the loop counter
            }
        }

        /// <summary>
        /// Prints everything in the store.
        /// Prints a number in front of the items when I display the cart.
        /// </summary>
        /// <param name="s">Name of the store.</param>
        private static void printInventory(Store s)
        {
            // Prints everything in the store
            for (int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine("Car # : " + i + " " + s.CarList[i]); // i is the item number for the loop counter
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add car to checkout.");

            choice = int.Parse(Console.ReadLine()); // int parse will cause the program to crash if the user types osmething other than an integer. use try {} catch {} to prevent an application crash.
            return choice;
        }
    }
}
