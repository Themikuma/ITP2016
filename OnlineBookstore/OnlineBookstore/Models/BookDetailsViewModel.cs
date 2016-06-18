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
    public double Price { get; set; }

    public string Picture { get; set; }

    public string Title { get; set; }

    public string Genre { get; set; }

    public string Description { get; set; }

    public int Stars { get; set; }

    public int Quantity { get; set; }

    public string Author { get; set; }

    public int Isbn { get; set; }

    public int Pages { get; set; }

        public List<string> BookReviews;
}
}