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
            List<string> genreList = new List<string>();

            genreList.Add("Fiction");
            genreList.Add("Science");
            genreList.Add("Business");
            genreList.Add("Art");
            genreList.Add("Biography");
            genreList.Add("NonFiction");
            model.GenreList = genreList;

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

            List<BookPreviewViewModel> genre3 = new List<BookPreviewViewModel>();
            genre3.Add(new BookPreviewViewModel { Description = "Business", Picture = "Blades.jpg", Price = 15, Stars = 1, Title = "Business1" });
            genre3.Add(new BookPreviewViewModel { Description = "More Business", Picture = "HolderCover.jpg", Price = 11, Stars = 2, Title = "Business2", Quantity = 12 });
            genre3.Add(new BookPreviewViewModel { Description = "Blah Business", Picture = "HolderCover.jpg", Price = 22.11, Stars = 3, Title = "Business3", Quantity = 12 });
            model.BooksByGenres.Add("Business", genre3);
            return View(model);


        }

        public ActionResult MarketPageSortedByGenre(string id)
        {

            SortedByGenreViewModel model = new SortedByGenreViewModel();
            List<string> genreList = new List<string>();
            genreList.Add("Fiction");
            genreList.Add("Science");
            genreList.Add("Business");
            genreList.Add("Art");
            genreList.Add("Biography");
            model.GenreList = genreList;
            model.genre = id;
            // Find selectedGenre from database
            return View(model);

        }

        // Bring the books from cart database, this is the example

        public CartListViewModel addCartList()
        {
            List<BookPreviewViewModel> CartList = new List<BookPreviewViewModel>();
            CartList.Add(new BookPreviewViewModel { Description = "Fiction", Picture = "HolderCover.jpg", Price = 50, Stars = 4, Title = "Fiction One", Quantity = 3 });
            CartList.Add(new BookPreviewViewModel { Description = "More Fiction", Picture = "shardblade.jpg", Price = 32.64, Stars = 1, Title = "Fiction Two", Quantity = 5 });
            CartList.Add(new BookPreviewViewModel { Description = "Even more Fiction", Picture = "shardblade.jpg", Price = 12.32, Stars = 3, Title = "Fiction Three" });
            CartListViewModel model = new CartListViewModel();
            model.CartList = CartList;
            model.TotalPrice = 0;
            model.CartListAmount = model.CartList.Count;
            return model;
        }

        [Authorize]
        public ActionResult CartList()
        {
            CartListViewModel model = addCartList();
            // If click add cart, Add bookpreviewviewpage to cartlistbookviewmodel

            foreach (var item in model.CartList)
            {
                double price = item.Price;
                model.TotalPrice = model.TotalPrice + price;
            }


            return View(model);
        }

        // Bring the books from cartlist to orderlist, this is the example
        public OrderPageViewModel addOrderList()
        {
            List<BookPreviewViewModel> OrderList = new List<BookPreviewViewModel>();
            OrderList.Add(new BookPreviewViewModel { Description = "Fiction", Picture = "HolderCover.jpg", Price = 50, Stars = 4, Title = "Fiction One", Quantity = 3 });
            OrderList.Add(new BookPreviewViewModel { Description = "More Fiction", Picture = "shardblade.jpg", Price = 32.64, Stars = 1, Title = "Fiction Two", Quantity = 5 });
            OrderPageViewModel model = new OrderPageViewModel();
            model.OrderPageModel = OrderList;
            model.TotalPrice = 0;
            return model;
        }

        public ActionResult OrderPage()
        {
            OrderPageViewModel model = addOrderList();

            foreach (var item in model.OrderPageModel)
            {
                double price = item.Price;
                model.TotalPrice = model.TotalPrice + price;
            }
            return View(model);
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