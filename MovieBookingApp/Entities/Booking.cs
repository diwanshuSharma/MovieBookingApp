using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.Entities
{
    public class Booking
    {
        public long BookingID { get; set; }
        public DateTime BookingDate { get; set; }
        public virtual List<Ticket> Tickets { get; set; } = new List<Ticket>();

        //[ForeignKey("Show")]
        public int ShowID { get; set; }
        public virtual Show Show { get; set; }

        //[ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
