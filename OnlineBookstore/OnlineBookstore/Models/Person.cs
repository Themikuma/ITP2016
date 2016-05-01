using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models
{
    public class Person
    {
        [Required]
        public String title { get; set; }
        [Required]
        public String firstName { get; set; }
        [Required]
        public String lastName { get; set; }
        [Required]
        public DateTime birthDate { get; set; }
        [Required]
        [StringLength(15)]
        public String userID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 8 )]
        public String password { get; set; }
        [Required]
        public String address { get; set; }
        [Required]
        public String country { get; set; }
        [Required]
        public String email { get; set; }
        public String phoneNum { get; set; }





    }
}