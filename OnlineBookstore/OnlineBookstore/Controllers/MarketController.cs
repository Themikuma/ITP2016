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
            Repository repository = new Repository();

            MarketPageViewModel model = new MarketPageViewModel();
            model.BooksByGenres = repository.GetBooksByGenre("");
            model.BestSellers = new List<BookPreviewViewModel>();

            //model.BooksByGenres = new Dictionary<string, List<BookPreviewViewModel>>();

            //model.BestSellerOne = new BookPreviewViewModel() { Description = "First best seller", Picture = "HolderCover.jpg", Price = 50, Stars = 4, Title = "Best book" };
            //model.BestSellerTwo = new BookPreviewViewModel() { Description = "Second best seller", Picture = "Blades.jpg", Price = 30, Stars = 4, Title = "Second book" };
            //model.BestSellerThree = new BookPreviewViewModel() { Description = "Third best seller", Picture = "shardblade.jpg", Price = 12.34, Stars = 4, Title = "Third book" };

            //List<BookPreviewViewModel> genre1 = new List<BookPreviewViewModel>();
            //genre1.Add(new BookPreviewViewModel { Description = "Fiction", Picture = "HolderCover.jpg", Price = 50, Stars = 4, Title = "Fiction One", Quantity = 3 });
            //genre1.Add(new BookPreviewViewModel { Description = "More Fiction", Picture = "shardblade.jpg", Price = 32.64, Stars = 1, Title = "Fiction Two", Quantity = 5 });
            //genre1.Add(new BookPreviewViewModel { Description = "Even more Fiction", Picture = "shardblade.jpg", Price = 12.32, Stars = 3, Title = "Fiction Three" });
            //model.BooksByGenres.Add("Fiction", genre1);

            //List<BookPreviewViewModel> genre2 = new List<BookPreviewViewModel>();
            //genre2.Add(new BookPreviewViewModel { Description = "Science", Picture = "Blades.jpg", Price = 31.41, Stars = 4, Title = "Science One" });
            //genre2.Add(new BookPreviewViewModel { Description = "More Science", Picture = "HolderCover.jpg", Price = 22.33, Stars = 3, Title = "Science Two", Quantity = 12 });
            //model.BooksByGenres.Add("Science", genre2);

            //List<BookPreviewViewModel> genre3 = new List<BookPreviewViewModel>();
            //genre3.Add(new BookPreviewViewModel { Description = "Business", Picture = "Blades.jpg", Price = 15, Stars = 1, Title = "Business1" });
            //genre3.Add(new BookPreviewViewModel { Description = "More Business", Picture = "HolderCover.jpg", Price = 11, Stars = 2, Title = "Business2", Quantity = 12 });
            //genre3.Add(new BookPreviewViewModel { Description = "Blah Business", Picture = "HolderCover.jpg", Price = 22.11, Stars = 3, Title = "Business3", Quantity = 12 });
            //model.BooksByGenres.Add("Business", genre3);


            return View(model);
        }


        // Bring the books from cart database, this is the example

        public CartListViewModel CartItems()
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

        //public JsonResult DeleteCartItem()
        //{

        //}

        [Authorize]
        public ActionResult CartList()
        {
            CartListViewModel model = CartItems();
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

        public ActionResult BookDetail()
        {
            BookDatailsViewModel model = new BookDatailsViewModel();
            model.Description = "Good";
            model.Genre = "Fiction";
            model.Picture = "";
            model.Price = 14;
            model.Quantity = 12;
            model.Stars = 3;
            model.Title = "title ";
            model.Author = "authorname";
            model.Isbn = 1234567;
            model.Pages = 300;
            model.BookReviews.Add("not bad");
            model.BookReviews.Add("So So");
            return View(model);
        }

    }
}