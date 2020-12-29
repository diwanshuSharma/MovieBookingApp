using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.Entities
{
    public class Screen
    {
        public int ScreenID { get; set; }
        public string ScreenName { get; set; }

        //[ForeignKey("Theatre")]
        public int TheatreID { get; set; }
        public virtual Theatre Theatre { get; set; }

        public virtual List<Seat> Seats { get; set; } = new List<Seat>();
        public virtual List<Show> Shows { get; set; } = new List<Show>();
    }
}
