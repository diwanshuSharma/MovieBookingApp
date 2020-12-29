using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.Entities
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }
    }
}
