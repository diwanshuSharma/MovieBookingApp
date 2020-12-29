using MovieBookingApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.BusinessLayer
{
    public class TicketBookingService : ITicketBookingService
    {
        public List<string> GetAllMovieNamesSeenByUserInTheatre(string theatreName, string loginName)
        {
            var db = new MovieBookingDB();

            var movieNames =  (from movie in db.Movies
                                
                               join show in db.Shows on movie.MovieID equals show.MovieID
                               join screen in db.Screens on show.ScreenID equals screen.ScreenID
                               join theatre in db.Theatres on screen.TheatreID equals theatre.TheatreID
                               join booking in db.Bookings on show.ShowID equals booking.ShowID
                               join user in db.Users on booking.UserID equals user.UserID
                                
                               where theatre.TheatreName == theatreName
                                        && user.LoginName == loginName
                               
                               select movie.MovieName).ToList();

            return movieNames;
        }

        public double GetTotalIncomeEarnedByTheatre(string theatreName)
        {
            var db = new MovieBookingDB();
            var totalIncome = (from theatre in db.Theatres
                               where theatre.TheatreName.Equals(theatreName)
                               select theatre.Screens.Sum(s => s.Shows.Sum(show => show.Cost))).FirstOrDefault();

            return totalIncome;
        }

        public int GetTotalNumberOfTicketsBookedByCity(string cityName)
        {
            var db = new MovieBookingDB();
            var totalTickets = (from ticket in db.Tickets
                                where ticket.Booking.User.Address.Equals(cityName)
                                select ticket).Count();

            return totalTickets;
        }

        public void DisplayReport(string movieName)
        {
            var db = new MovieBookingDB();

            var movieNames = (from movies in db.Movies

                              join show in db.Shows on movies.MovieID equals show.MovieID
                              join screen in db.Screens on show.ScreenID equals screen.ScreenID
                              join theatre in db.Theatres on screen.TheatreID equals theatre.TheatreID
                              join booking in db.Bookings on show.ShowID equals booking.ShowID
                              join ticket in db.Tickets on booking.BookingID equals ticket.BookingID
                              where movies.MovieName == movieName
                              group new { theatre.TheatreName, movies.MovieName,booking.BookingID } 
                              by new { theatre.TheatreName, movies.MovieName,booking.Tickets} into sName
                              select new {
                                  TheatreName = sName.Key.TheatreName,
                                  Moviename = sName.Key.MovieName,
                                  NumberOfTicketSold = sName.Key.Tickets.Count()
                              }).ToList();            
        }
    }
}
