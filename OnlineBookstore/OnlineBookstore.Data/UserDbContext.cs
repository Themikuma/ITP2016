using Microsoft.AspNet.Identity.EntityFramework;
using OnlineBookstore.Data.Migrations;
using OnlineBookstore.Models;
using System.Data.Entity;

namespace OnlineBookstore.Data
{
    public class UserDbContext : IdentityDbContext<ApplicationUser>
    {
        public UserDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion
                <UserDbContext, UserConfiguration>());
        }

        public static UserDbContext Create()
        {
            return new UserDbContext();
        }
    }
}
