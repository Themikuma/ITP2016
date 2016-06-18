using OnlineBookstore.Data;
using OnlineBookstore.Models.BookstoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.DAL
{
    public class BookstoreRepository
    {
        private BookstoreDbContext context;
        public BookstoreRepository()
        {
            this.context = new BookstoreDbContext();
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return context.Books;
        }
        public void AddBook(Book book)
        {
            context.Books.Add(book);
        }
    }
}
