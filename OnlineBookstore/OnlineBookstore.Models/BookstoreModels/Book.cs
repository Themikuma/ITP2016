using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models.BookstoreModels
{
    public class Book
    {
        [Required]
        [Key]
        public int Isbn { get; set; }

        [Required]
        public float Price { get; set; }

        public int Sold { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int Pages { get; set; }

        public DateTime Published { get; set; }

        [MaxLength(255)]
        public string Language { get; set; }

        [MaxLength(255)]
        public string GoodreadsLink { get; set; }

        [MaxLength(255)]
        public string Genre { get; set; }

        public int Stars { get; set; }

        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string Picture { get; set; }
    }
}
