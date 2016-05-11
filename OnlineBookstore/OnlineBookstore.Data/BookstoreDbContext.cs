using OnlineBookstore.Data.Migrations;
using OnlineBookstore.Models.BookstoreModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Data
{
    public class BookstoreDbContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public BookstoreDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<BookstoreDbContext,
                BookstoreConfiguration>());
        }
    }
}
