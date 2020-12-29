using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.Entities
{
    public class Theatre
    {
        public int TheatreID { get; set; }
        public string TheatreName { get; set; }
        public virtual List<Screen> Screens { get; set; } = new List<Screen>();
    }
}
