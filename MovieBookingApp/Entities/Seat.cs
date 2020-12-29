using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.Entities
{
    public class Seat
    {
        public char RowID { get; set; }
        public int SeatID { get; set; }

        [ForeignKey("Ticket")]
        public int TicketID { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
