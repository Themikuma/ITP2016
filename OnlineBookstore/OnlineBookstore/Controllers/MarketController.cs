using Microsoft.AspNet.Identity;
using OnlineBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBookstore.Controllers
{
    [Authorize]
    public class MarketController : Controller
    {
        // GET: Market
        [AllowAnonymous]
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
        
        public ActionResult CartList()
        {
            Repository repository = new Repository();
            IEnumerable<CartViewModel> model = repository.GetUnfinishedOrders(User.Identity.GetUserId());

            return View(model);
        }
        
        public ActionResult OrderPage()
        {
            Repository repository = new Repository();
            OrderPageViewModel model = repository.GetUserData(User.Identity.GetUserId());
            model.Items = repository.GetUnfinishedOrders(User.Identity.GetUserId());
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
        public ActionResult OrderSuccess()
        {
            Repository repository = new Repository();
            repository.FinishOrder(User.Identity.GetUserId());
            return View();
        }

    }
}