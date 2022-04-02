using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2Comp2084.Models
{
    public class Owner
    {
        [Required]
        [Key]
        public int OwnerID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OwnerName { get; set; }

        [Required]
        public int OwnerAge { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OwnerAdress { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OwnerPhoneNumber { get; set; }

        //Navigation properties
        public List<TattooShop> TattooShop { get; set; }
    }
}
