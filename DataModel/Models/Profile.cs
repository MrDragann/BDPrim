using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Models
{
    public class Profile
    {
        [Key]
        [ForeignKey("CustomerOf")]
        public int CustomerId { get; set; }
        public string RegistrationDate { get; set; }
        public string LastLoginDate { get; set; }

        public Customer CustomerOf { get; set; }
    }
}
