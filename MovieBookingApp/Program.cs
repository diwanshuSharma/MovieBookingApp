using MovieBookingApp.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketBookingService service = new TicketBookingService();
            int choice;
            while (true)
            {
                Console.Write("Menu:\n1. Get Total Income\n2. Get All Movies Seen\n3. Get Total Number of Tickets\n4. Exit\nEnter: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter Theatre Name: ");
                        string theatre = Console.ReadLine();
                        double income = service.GetTotalIncomeEarnedByTheatre(theatre);
                        Console.WriteLine("Total Income: " + income + "\n");
                        break;

                    case 2:
                        List<string> movies = new List<string>();
                        Console.Write("Enter Login Name: ");
                        string login = Console.ReadLine();
                        Console.Write("Enter Theatre Name: ");
                        theatre = Console.ReadLine();
                        movies = service.GetAllMovieNamesSeenByUserInTheatre(theatre, login);
                        Console.WriteLine("Movies: ");
                        foreach (string movie in movies)
                        {
                            Console.WriteLine(movie);
                        }
                        break;

                    case 3:
                        Console.Write("\nEnter City Name: ");
                        string city = Console.ReadLine();
                        int count = service.GetTotalNumberOfTicketsBookedByCity(city);
                        Console.WriteLine("Total Tickets: " + count + "\n");
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
