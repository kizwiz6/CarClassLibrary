using CarClassLibrary;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}