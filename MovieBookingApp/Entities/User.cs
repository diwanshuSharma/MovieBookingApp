using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.Entities
{
    public class User
    {
        public long UserID { get; set; }
        public string LoginName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();

        //[ForeignKey("Address")]
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
    }
}
