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

        public Dictionary<string, List<BookPreviewViewModel>> GetBooksByGenre(string genre)
        {
            if (string.IsNullOrEmpty(genre))
            {
                genre = "";
            }
            var filtered = context.Books.Where(t => t.Genre.Contains(genre));
            return GroupBooksByGenre(filtered);
        }
    }
}