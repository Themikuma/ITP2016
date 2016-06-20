using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models
{

    public class MarketPageViewModel
    {
        public List<BookPreviewViewModel> BestSellers { get; set; }

        public Dictionary<string, List<BookPreviewViewModel>> BooksByGenres;

        public int FilterBy { get; set; }
    }


    public class CartViewModel
    {
        public CartViewModel(int id, string title, string author, float price)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public float Price { get; set; }

    }

    public class OrderPageViewModel
    {
        public IEnumerable<CartViewModel> Items { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }


        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}