using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Data.Migrations
{
    public class BookstoreConfiguration : DbMigrationsConfiguration<BookstoreDbContext>
    {
        public BookstoreConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BookstoreDbContext";
        }
        protected override void Seed(BookstoreDbContext context)
        {
            base.Seed(context);
        }
    }
}
