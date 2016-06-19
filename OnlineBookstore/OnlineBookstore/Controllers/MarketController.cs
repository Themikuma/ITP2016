using Microsoft.AspNet.Identity;
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
        public ActionResult MarketPage(int? filterBy, string filterText)
        {
            Repository repository = new Repository();

            MarketPageViewModel model = new MarketPageViewModel();
            switch (filterBy)
            {
                case 1: break;
                case 2: break;
                case 3: model.BooksByGenres = repository.GetBooksByGenre(filterText);
                    break;
                default:
                    model.BooksByGenres = repository.GetAllBooks();
                    break;
            }
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

        
        //public JsonResult DeleteCartItem()
        //{

        //}

        [Authorize]
        public ActionResult CartList()
        {
            Repository repository = new Repository();
            IEnumerable<CartViewModel> model = repository.GetUnfinishedOrders(User.Identity.GetUserId());            

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
            Repository repository = new Repository();
            repository.FinishOrder(User.Identity.GetUserId());
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