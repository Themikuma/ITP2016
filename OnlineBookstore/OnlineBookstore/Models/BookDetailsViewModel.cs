using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace OnlineBookstore.Models
{
    public class BookDetailsViewModel
    {
        public BookDetailsViewModel()
        {
        }

        public BookDetailsViewModel(float price, string picture, string title, string genre,
            string description, int stars, int quantity, string author, string isbn, int pages, string goodreadsLink)
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
            this.GoodreadsLink = goodreadsLink;
        }

        public double Price { get; set; }

        public string Picture { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        public int Stars { get; set; }

        public int Quantity { get; set; }

        public string Author { get; set; }

        public string Isbn { get; set; }

        public int Pages { get; set; }

        public string GoodreadsLink { get; set; }
    }
}