namespace Security.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Security.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    // Add this to enable roles
    using Microsoft.AspNet.Identity;
    using System.Security.Claims;



    internal sealed class Configuration : DbMigrationsConfiguration<Security.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Security.Models.ApplicationDbContext";
        }

        // SEED FOR CLAIMS
        protected override void Seed(ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new ApplicationRoleManager(roleStore);

            // Ensure Stephen
            var user = userManager.FindByName("Stephen@CoderCamps.com");
            if (user == null)
            {
                // create user
                user = new ApplicationUser
                {
                    UserName = "Stephen@CoderCamps.com",
                    Email = "Stephen@CoderCamps.com"
                };
                userManager.Create(user, "Secret123!");

                // add claims
                userManager.AddClaim(user.Id, new Claim("CanEditProducts", "true"));
                userManager.AddClaim(user.Id, new Claim(ClaimTypes.DateOfBirth, "12/25/1966"));
            }
        }




        //protected override void Seed(Security.Models.ApplicationDbContext context)
        //{
        //    //  This method will be called after migrating to the latest version.

        //    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //    //  to avoid creating duplicate seed data. E.g.
        //    //
        //    //    context.People.AddOrUpdate(
        //    //      p => p.FullName,
        //    //      new Person { FullName = "Andrew Peters" },
        //    //      new Person { FullName = "Brice Lambson" },
        //    //      new Person { FullName = "Rowan Miller" }
        //    //    );
        //    //
        //}


        // USE TO ENABLE ROLES
        //protected override void Seed(ApplicationDbContext context)
        //{
        //    var userStore = new UserStore<ApplicationUser>(context);
        //    var userManager = new ApplicationUserManager(userStore);
        //    var roleStore = new RoleStore<IdentityRole>(context);
        //    var roleManager = new ApplicationRoleManager(roleStore);

        //    // Ensure Admin role
        //    if (!roleManager.RoleExists("Admin"))
        //    {
        //        roleManager.Create(new IdentityRole("Admin"));
        //    }


        //    // Ensure Stephen
        //    var user = userManager.FindByName("Stephen.Walther@CoderCamps.com");
        //    if (user == null)
        //    {
        //        user = new ApplicationUser
        //        {
        //            UserName = "Stephen.Walther@CoderCamps.com",
        //            Email = "Stephen.Walther@CoderCamps.com"
        //        };
        //        userManager.Create(user, "Secret123!");
        //    }

        //    // Make Stephen Admin
        //    var rolesForUser = userManager.GetRoles(user.Id);
        //    if (!rolesForUser.Contains("Admin"))
        //    {
        //        userManager.AddToRole(user.Id, "Admin");
        //    }

        //}

    }
}
