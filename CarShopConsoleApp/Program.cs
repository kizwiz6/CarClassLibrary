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

                    default:
                        break;
                }


                action = chooseAction(); // ask for a new action - gives another chance to break out the loop
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Prints everything in the store
        /// </summary>
        /// <param name="s">Name of the store.</param>
        private static void printInventory(Store s)
        {
            // Prints everything in the store
            foreach (Car c in s.CarList)
            {
                Console.WriteLine("Car: " + c);
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
