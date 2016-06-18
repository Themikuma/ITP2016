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
<<<<<<< HEAD
    }
=======


        public string SearchTitle { get; set; }
>>>>>>> 8ac9c28dc0e185a35cc3d9f163aa982733eb7a68

        public string SearchAuthor { get; set; }

        public string SearchIsbn { get; set; }

        [Required]
        public string SelectedSearchOption { get; set; }

        [Required]
        public string SearchBook { get; set; }

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