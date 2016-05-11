using OnlineBookstore.DAL;
using OnlineBookstore.Models.BookstoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBookstore.Controllers
{
    public class BookDetailsController : Controller
    {
        // GET: BookDetails
        private BookstoreRepository repository = new BookstoreRepository();
        public ActionResult Index()
        {
            Book book = new Book()
            {
                Isbn = 123454,
                Price = 15,
                Quantity = 5
            };
            repository.AddBook(book);
            return View();
        }
    }
}