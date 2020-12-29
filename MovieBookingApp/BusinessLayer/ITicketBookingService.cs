using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.BusinessLayer
{
    public interface ITicketBookingService
    {
        double GetTotalIncomeEarnedByTheatre(string theatreName);
        List<string> GetAllMovieNamesSeenByUserInTheatre(string theatreName, string loginName);
        int GetTotalNumberOfTicketsBookedByCity(string cityName);
    }
}
