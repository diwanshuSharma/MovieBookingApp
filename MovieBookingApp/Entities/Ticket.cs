using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.Entities
{
    public class Ticket
    {
        public long TicketID { get; set; }
        public virtual List<Seat> Seats { get; set; } = new List<Seat>();

        [ForeignKey("Booking")]
        public int BookingID { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
