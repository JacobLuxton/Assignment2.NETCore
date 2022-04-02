using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2Comp2084.Models
{
    public class Employee
    {
        [Required]
        [Key]
        public int EmployeeID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public int EmployeeAge { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string TattooSpecialty { get; set; }


        public int? TattooShopID { get; set; }
        public TattooShop TattooShop { get; set; }

        public List<Booking> Booking { get; set; }
    }
}
