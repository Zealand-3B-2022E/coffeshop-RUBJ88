// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How high is a discount?");
        string strDiscount = Console.ReadLine();
        int discount = int.Parse(strDiscount);
        Cortado cortado = new Cortado(discount);
        Latte latte = new Latte(discount);
        BlackCoffee blackCoffee = new BlackCoffee(discount);

        List<Coffee> coffeeList = new List<Coffee>();
        coffeeList.Add(blackCoffee);
        coffeeList.Add(cortado);
        coffeeList.Add(latte);

        foreach (Coffee coffee in coffeeList)
        {
            
            Console.WriteLine(coffee.Price);
        }


      
       

    }
}





