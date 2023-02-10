using System;

namespace TicketSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Event Ticket Sales Program!");
            Console.WriteLine("There are four types of tickets: Orchestra ($100), Floor ($75), Tier 1 ($50), Tier 2 ($40), Tier 3 ($35)");
            Console.WriteLine("Please enter the type of ticket you have (Orchestra, Floor, Tier 1, Tier 2, or Tier 3):");

            string ticketType = Console.ReadLine();
            int ticketPrice = 0;
            int numberOfTickets = 0;
            int totalCost = 0;

            Console.WriteLine("Please enter the number of tickets you have:");
            numberOfTickets = int.Parse(Console.ReadLine());

            switch (ticketType)
            {
                case "Orchestra":
                    ticketPrice = 100;
                    break;
                case "Floor":
                    ticketPrice = 75;
                    break;
                case "Tier 1":
                    ticketPrice = 50;
                    break;
                case "Tier 2":
                    ticketPrice = 40;
                    break;
                case "Tier 3":
                    ticketPrice = 35;
                    break;
                default:
                    Console.WriteLine("Invalid ticket type. Please try again.");
                    break;
            }

            totalCost = ticketPrice * numberOfTickets;
            Console.WriteLine("\nTable display with columns: Type of Ticket; Ticket Price; # of Tickets Sold; Cost");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "Type of Ticket", "Ticket Price", "# of Tickets Sold", "Cost");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", ticketType, "$" + ticketPrice, numberOfTickets, "$" + totalCost);
        }
    }
}
