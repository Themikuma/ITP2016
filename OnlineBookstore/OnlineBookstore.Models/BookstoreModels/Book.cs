using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookstore.Models.BookstoreModels
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(10, MinimumLength = 10)]
        public string Isbn { get; set; }

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

        [MaxLength(1500)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string Picture { get; set; }
    }
}
