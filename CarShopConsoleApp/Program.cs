using CarClassLibrary;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // WElcome message
            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            // Action
            int action = chooseAction();

            // When we're done with the loop we'll be done with the program
            // Type in 0 to end the program.
            while (action != 0)
            {
                Console.WriteLine("You chose " + action);
                action = chooseAction(); // ask for a new action - gives another chance to break out the loop
            }

            // First constructor creates a generic car
            Car c = new Car("Nissan", "Sentra", 7322);
            // Second constructor uses the paramaters
            Car d = new Car("Ford", "Mustang", 9200);

            Console.WriteLine("Car c is as follows " + c.Make + " " + c.Model + " " + c.Price);
            Console.WriteLine("Car d is as follows " + d.Make + " " + d.Model + " " + d.Price);

            Store s = new Store();

            s.ShoppingList.Add(c); // adds car c
            s.ShoppingList.Add(d); // adds car d

            // Checkout - value of everything in the store.
            decimal total = s.Checkout();

            Console.WriteLine("Store value is " + total);

            Console.ReadLine();
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
