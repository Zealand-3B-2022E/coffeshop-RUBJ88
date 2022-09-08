// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        cortado cordado = new cortado();
        latte latte = new latte();
        BlackCoffee blackCoffee = new BlackCoffee();



        List<BlackCoffee> coffeeListt = new List<BlackCoffee>();
        coffeeListt.Add(blackCoffee);
        coffeeListt.Add(latte);
        coffeeListt.Add(cordado);

        foreach (Coffee in coffeeListt)
        {
            Console.WriteLine(coffee.strenght));
            Console.WriteLine(coffee.price());
       
        }

    }
}





