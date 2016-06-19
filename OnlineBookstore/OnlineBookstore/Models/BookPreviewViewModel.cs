using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    public class BookPreviewViewModel
    {
        public BookPreviewViewModel()
        {
        }

        public BookPreviewViewModel(string isbn, float price, string picture, string title, string genre,
            string description, int stars, int quantity)
        {
            this.Isbn = isbn;
            this.Price = price;
            this.Picture = picture;
            this.Title = title;
            this.Genre = genre;
            this.Description = description;
            this.Stars = stars;
            this.Quantity = quantity;
        }

        public string Isbn { get; set; }

        public double Price { get; set; }

        public string Picture { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        public int Stars { get; set; }

        public int Quantity { get; set; }
    }
}