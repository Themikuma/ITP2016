using OnlineBookstore.Data;
using OnlineBookstore.Models;
using OnlineBookstore.Models.BookstoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookstore
{
    public class Repository
    {
        private DbContext context;

        public Repository()
        {
            context = new DbContext();
        }

        public Dictionary<string, List<BookPreviewViewModel>> GetAllBooks()
        {
            var books = context.Books;
            return GroupBooksByGenre(books);

        }

        public Dictionary<string, List<BookPreviewViewModel>> GetBooksByGenre(string genre)
        {
            if (string.IsNullOrEmpty(genre))
            {
                genre = "";
            }
            var filtered = context.Books.Where(t => t.Genre.Contains(genre));
            return GroupBooksByGenre(filtered);
        }

        private Dictionary<string, List<BookPreviewViewModel>> GroupBooksByGenre(IEnumerable<Book> books)
        {
            Dictionary<string, List<BookPreviewViewModel>> result = new Dictionary<string, List<BookPreviewViewModel>>();
            foreach (var book in books)
            {
                List<BookPreviewViewModel> booksInGenre;
                if (result.ContainsKey(book.Genre))
                {
                    booksInGenre = result[book.Genre];
                }
                else
                {
                    booksInGenre = new List<BookPreviewViewModel>();
                }
                booksInGenre.Add(new BookPreviewViewModel(book.Price, book.Picture, book.Title,
                    book.Genre, book.Description, book.Stars, book.Quantity));
                result[book.Genre] = booksInGenre;
            }
            return result;
        }

        public void CreateOrder(string userId, string isbn)
        {
            OrderItem newOrder = new OrderItem();
            newOrder.UserId = userId;
            newOrder.BookIsbn = isbn;
            newOrder.IsFinal = false;
            context.Orders.Add(newOrder);
        }

        public IEnumerable<CartViewModel> GetUnfinishedOrders(string userId)
        {
            var orders = context.Orders.Where(t => t.UserId == userId && t.IsFinal == false).ToList();
            List<CartViewModel> result = new List<CartViewModel>();
            foreach (var order in orders)
            {
                CartViewModel newOrder = new CartViewModel(order.Book.Title, order.Book.Author, order.Book.Price);
                result.Add(newOrder);
            }
            return result;
        }

        public void FinishOrder(string userId)
        {
            var orders = context.Orders.Where(t => t.UserId == userId && t.IsFinal == false).ToList();
            foreach (var order in orders)
            {
                order.IsFinal = true;
            }
            context.SaveChanges();
        }
    }
}