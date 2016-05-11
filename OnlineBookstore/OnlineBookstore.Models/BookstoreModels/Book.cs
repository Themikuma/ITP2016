using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models.BookstoreModels
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public int Isbn { get; set; }
        
        [Required]
        public int Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        //[Required]
        public int Pages { get; set; }

        //[Required]
        public int Published { get; set; }

        [MaxLength(255)]
        public string Language { get; set; }

        [MaxLength(255)]
        public string GoodreadsLink { get; set; }

        //[Required]
        [MaxLength(255)]
        public string Title { get; set; }
    }
}
