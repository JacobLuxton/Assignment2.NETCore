using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2Comp2084.Models
{
    public class Booking
    {

        [Required]
        [Key]
        public int BookingID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public int ClientID { get; set; }
        public Client Client { get; set; }

        [Required]
        public int TattooShopID { get; set; }
        public TattooShop TattooShop { get; set; }

    }
}
