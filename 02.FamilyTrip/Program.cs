using System;

namespace _02.FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            double expense = double.Parse(Console.ReadLine());

            if (days > 7)
            {
                pricePerNight *= 0.95;
            }

            double hotelPrice = days * pricePerNight;
            double expensesMoney = budget * expense / 100;
            double totalMoneyNeeded = hotelPrice + expensesMoney;
            double fianlPriceDifference = Math.Abs(totalMoneyNeeded - budget);

            if (budget >= totalMoneyNeeded)
            {
                Console.WriteLine($"Ivanovi will be left with {fianlPriceDifference:f2} leva after vacation.");
                
            }
            else
            {
                Console.WriteLine($"{ fianlPriceDifference:f2} leva needed.");
            }
        }
    }
}
