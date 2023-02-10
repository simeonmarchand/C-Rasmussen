using System;

namespace JessieComputerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Jessie's Computer Shop Profit Calculator");
            Console.WriteLine("This program will help calculate the markup required for a desired profit.");
            Console.WriteLine("Please enter the following information:");

            Console.WriteLine("\nEnter the total cost of the merchandise:");
            double merchandiseCost = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the yearly salary of employees:");
            double employeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the yearly rent:");
            double storeRent = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the monthly electricity cost:");
            double electricityCost = double.Parse(Console.ReadLine());

            double totalExpenses = merchandiseCost + employeeSalary + storeRent + (electricityCost * 12);
            double desiredProfit = totalExpenses * 0.2;
            double markup = desiredProfit / 5200;
            double pricePerComputer = merchandiseCost + markup;

            Console.WriteLine("\nThe desired profit is: $" + desiredProfit);
            Console.WriteLine("\nThe markup required for each computer is: $" + markup);
            Console.WriteLine("\nThe price of each computer should be: $" + pricePerComputer);
        }
    }
}
