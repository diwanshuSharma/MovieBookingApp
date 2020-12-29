using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.Entities
{
    public class Show
    {
        public int ShowID { get; set; }
        public DateTime ShowTime { get; set; }
        public double Cost { get; set; }

        //[ForeignKey("Screen")]
        public int ScreenID { get; set; }
        public virtual Screen Screen { get; set; }

        //[ForeignKey("Movie")]
        public int MovieID { get; set; }
        public virtual Movie Movie { get; set; }

        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
