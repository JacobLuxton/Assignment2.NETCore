using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2Comp2084.Models
{
    public class TattooShop
    {
        [Required]
        [Key]
        public int TattooShopID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string TattooShopName { get; set; }

        [Required]
        public int OwnerID {get; set;}
        public Owner Owner { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string TattooShopLocation { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string TattooShopNumber { get; set; }

        public List<Booking> Booking { get; set; }

        public List<Employee> Employee { get; set; }

    }
}
