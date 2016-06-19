using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace OnlineBookstore.Models
{
    public class BookDatailsViewModel { 
    public BookDatailsViewModel()
    {
    }

    public BookDatailsViewModel(float price, string picture, string title, string genre,
        string description, int stars, int quantity, string author, int isbn, int pages)
    {
        this.Price = price;
        this.Picture = picture;
        this.Title = title;
        this.Genre = genre;
        this.Description = description;
        this.Stars = stars;
        this.Quantity = quantity;
            this.Author = author;
            this.Isbn = isbn;
            this.Pages = pages;

        }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Stars { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int Isbn { get; set; }
        [Required]
        public int Pages { get; set; }
        [Required]
        public string BookReviewsURL;
}
}