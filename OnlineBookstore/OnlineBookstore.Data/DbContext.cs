using Microsoft.AspNet.Identity.EntityFramework;
using OnlineBookstore.Data.Migrations;
using OnlineBookstore.Models;
using OnlineBookstore.Models.BookstoreModels;
using System.Data.Entity;

namespace OnlineBookstore.Data
{
    public class DbContext : IdentityDbContext<ApplicationUser>
    {
        public DbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion
                <DbContext, UserConfiguration>());
        }

        public DbSet<Book> Books;

        public DbSet<OrderItem> Orders;

        public static DbContext Create()
        {
            return new DbContext();
        }
    }
}
