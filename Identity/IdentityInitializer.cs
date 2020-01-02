using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web_UI.Entity;

namespace Web_UI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //rolleri

            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);

                var manage = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole(){ Name = "admin", Description = "admin rolü" };

                manage.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);

                var manage = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };

                manage.Create(role);
            }
            if (!context.Users.Any(i => i.Name == "berkakkavak"))
            {
                var store = new UserStore<ApplicationUser>(context);

                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "berk", Surname = "akkavak", UserName = "berkakkavak", Email = "berkak-@outlook.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Name == "gamzeakkavak"))
            {
                var store = new UserStore<ApplicationUser>(context);

                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "gamze", Surname = "akkavak", UserName = "gamzeakkavak", Email = "gamzeak@outlook.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }

          
            //user
            base.Seed(context);
        }


    }
}