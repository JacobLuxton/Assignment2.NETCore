using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2Comp2084.Models
{
    public class Client
    {
        [Required]
        [Key]
        public int ClientID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ClientName { get; set; }

        [Required]
        public int ClientAge { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ClientPhoneNumber { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string ClientGender { get; set; }

        public List<Booking> Booking { get; set; }

    }
}
