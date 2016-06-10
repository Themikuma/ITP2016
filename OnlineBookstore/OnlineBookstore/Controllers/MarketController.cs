using OnlineBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBookstore.Controllers
{
    public class MarketController : Controller
    {
        // GET: Market
        public ActionResult MarketPage()
        {
            MarketPageViewModel model = new MarketPageViewModel();
            model.BooksByGenres = new Dictionary<string, List<BookPreviewViewModel>>();
            model.BestSellerOne = new BookPreviewViewModel() { Description = "First best seller", Picture = "HolderCover.jpg", Price = 50, Stars = 4, Title = "Best book" };
            model.BestSellerTwo = new BookPreviewViewModel() { Description = "Second best seller", Picture = "Blades.jpg", Price = 30, Stars = 4, Title = "Second book" };
            model.BestSellerThree = new BookPreviewViewModel() { Description = "Third best seller", Picture = "shardblade.jpg", Price = 12.34, Stars = 4, Title = "Third book" };
            List<BookPreviewViewModel> genre1 = new List<BookPreviewViewModel>();
            genre1.Add(new BookPreviewViewModel { Description = "Fiction", Picture = "HolderCover.jpg", Price = 50, Stars = 4, Title = "Fiction One", Quantity = 3 });
            genre1.Add(new BookPreviewViewModel { Description = "More Fiction", Picture = "shardblade.jpg", Price = 32.64, Stars = 1, Title = "Fiction Two", Quantity = 5 });
            genre1.Add(new BookPreviewViewModel { Description = "Even more Fiction", Picture = "shardblade.jpg", Price = 12.32, Stars = 3, Title = "Fiction Three" });
            model.BooksByGenres.Add("Fiction", genre1);
            List<BookPreviewViewModel> genre2 = new List<BookPreviewViewModel>();
            genre2.Add(new BookPreviewViewModel { Description = "Science", Picture = "Blades.jpg", Price = 31.41, Stars = 4, Title = "Science One" });
            genre2.Add(new BookPreviewViewModel { Description = "More Science", Picture = "HolderCover.jpg", Price = 22.33, Stars = 3, Title = "Science Two", Quantity = 12 });
            model.BooksByGenres.Add("Science", genre2);
            return View(model);
        }
        public ActionResult MarketPageSortedByGenre()
        {
            return View();
        }

        [Authorize]
        public ActionResult CartList()
        {
            return View();
        }

        public ActionResult OrderPage()
        {
            return View();
        }

        public ActionResult BookDetails(/*int bookId*/)
        {
            /*int id = bookId;*/

            BookDetailsViewModel model = new BookDetailsViewModel();
            model = new BookDetailsViewModel() { Title = "Test Book", Author = "Need a name", Description = "This story takes place in blah blah", ISBN = 325908249 };
            return View(model);
        }

    }
}