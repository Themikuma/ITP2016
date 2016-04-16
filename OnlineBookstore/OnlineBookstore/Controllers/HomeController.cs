using OnlineBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace OnlineBookstore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginPage()
        {
            return View();
        }

       public ActionResult Login(string username, string password)
         { 
             if (username=="123" && password=="456") 
             { 
                 return View("LoginSuccess"); 
             } 
           return View("LoginFail"); 
       }

        public ActionResult RegistrationForm()
        {
            return View();
        }

        public ActionResult Registration(String title, String firstName, String lastName, String year, String month, String day, String username,
          String password, String confirmPassword, String address, String zipCode, String country, String email, String teleNum, String newsAgree,
          String termAgree) // I don't know how can i receive the value of checkbox. 
        {
            return View();
        }


        public JsonResult GetAllBooks()
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book { ISBN = "124", Author = "Pesho", Title = "Peter pan" };
            Book book2 = new Book { ISBN = "TTT", Author = "Gosho", Title = "pan" };
            Book book3 = new Book { ISBN = "RRR", Author = "Tosho", Title = "++++++" };
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);            
            return Json(new { data = books });
        }

        public JsonResult FooMethod()
        {
            string[] s = { "123", "34", "43" };
            return Json(s);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}