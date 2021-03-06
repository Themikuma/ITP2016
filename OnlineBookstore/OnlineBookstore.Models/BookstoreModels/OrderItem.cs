﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Models.BookstoreModels
{
    public class OrderItem
    {
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual Book Book { get; set; }

        [Required]
        [ForeignKey("Book")]
        public string BookIsbn { get; set; }

        [Required]
        public bool IsFinal { get; set; }
    }
}
