using System;

namespace _01._Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawbariesPrice = double.Parse(Console.ReadLine());
            double bananasInKg = double.Parse(Console.ReadLine());
            double orangesInKg = double.Parse(Console.ReadLine());
            double raspberriesInKg = double.Parse(Console.ReadLine());
            double strawbariesInKg = double.Parse(Console.ReadLine());

            //•	цената на малините е на половина по - ниска от тази на ягодите;
            //    •	цената на портокалите е с 40 % по - ниска от цената на малините;
            //    •	цената на бананите е с 80 % по - ниска от цената на малините.

            double raspberriesPrice = strawbariesPrice * 0.5;
            double oranagesPrice = raspberriesPrice * 0.6;
            double banansPrice = raspberriesPrice * 0.2;

            double totalPrice = strawbariesPrice * strawbariesInKg + banansPrice * bananasInKg + raspberriesPrice * raspberriesInKg + oranagesPrice * orangesInKg;

             Console.WriteLine($"{totalPrice:f2}");


        }
    }
}
