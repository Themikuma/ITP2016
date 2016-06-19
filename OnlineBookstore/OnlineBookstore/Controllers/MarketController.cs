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

            if (string.IsNullOrEmpty(filterText))
            {
                filterText = "";
            }
            MarketPageViewModel model = new MarketPageViewModel();
            switch (filterBy)
            {
                case 1:
                    model.BooksByGenres = repository.GetBooksByTitle(filterText);
                    break;
                case 2:
                    model.BooksByGenres = repository.GetBooksByAuthor(filterText);
                    break;
                case 3:
                    model.BooksByGenres = repository.GetBooksByGenre(filterText);
                    break;
                default:
                    model.BooksByGenres = repository.GetAllBooks();
                    break;
            }
            model.BestSellers = new List<BookPreviewViewModel>();
            return View(model);
        }
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

        public ActionResult DeleteCartItem(int id)
        {
            Repository repository = new Repository();
            repository.DeleteCartItem(id);
            return RedirectToAction("CartList");
        }

        public ActionResult OrderBook(string isbn)
        {
            Repository repository = new Repository();
            repository.CreateOrder(User.Identity.GetUserId(), isbn);
            return RedirectToAction("CartList");
        }

    }
}