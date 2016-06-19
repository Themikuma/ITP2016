using Microsoft.AspNet.Identity;
using OnlineBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBookstore.Controllers
{
    public class DetailsController : Controller
    {

        public ActionResult BookDetailsPage()
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
            model.BookReviewsURL = "";
            return View(model);
        }
    }
}