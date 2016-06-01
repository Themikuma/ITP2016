using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models.BookstoreModels
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public int Isbn { get; set; }
        
        [Required]
        public float Price { get; set; }

        [Required]
        public int Quantity { get; set; }
        
        public int Pages { get; set; }
        
        public DateTime Published { get; set; }

        [MaxLength(255)]
        public string Language { get; set; }

        [MaxLength(255)]
        public string GoodreadsLink { get; set; }
        
        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string Picture { get; set; }
    }
}
