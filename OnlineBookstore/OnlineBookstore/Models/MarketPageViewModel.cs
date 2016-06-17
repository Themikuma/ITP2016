using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models
{

    public class MarketPageViewModel
    {
        public BookPreviewViewModel BestSellerOne { get; set; }

        public BookPreviewViewModel BestSellerTwo { get; set; }

        public BookPreviewViewModel BestSellerThree { get; set; }

        public Dictionary<string, List<BookPreviewViewModel>> BooksByGenres;


        public List<string> GenreList { get; set; }

        [Required]
        public string SelectedGenre { get; set; }

        [Required]
        public string SearchBookTitle { get; set; }


    }

    public class SortedByGenreViewModel
    {

        public string genre { get; set; }

        public List<BookPreviewViewModel> SortedBook;

        public List<string> GenreList;
    }

    public class CartListViewModel
    {

        public List<BookPreviewViewModel> CartList;

        public double TotalPrice;

        public int CartListAmount;

    }

    public class OrderPageViewModel
    {
        public List<BookPreviewViewModel> OrderPageModel;

        public double TotalPrice;

        public string UserName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }


        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }



    }
}