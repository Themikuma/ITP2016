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

        public Dictionary<string, List<BookPreviewViewModel>> GetBooksByGenre(string genre)
        {
            var books = context.Books.Where(t => t.Genre.Contains(genre));
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
                booksInGenre.Add(new BookPreviewViewModel(book.Price, book.Picture, book.Title, book.Genre, book.Description, 3, book.Quantity));
                result[book.Genre] = booksInGenre;
            }
            return result;
        }
    }
}