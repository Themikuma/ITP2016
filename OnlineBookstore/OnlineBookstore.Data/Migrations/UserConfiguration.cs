namespace OnlineBookstore.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class UserConfiguration : DbMigrationsConfiguration<Data.DbContext>
    {
        public UserConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "UserDbContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Data.DbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
