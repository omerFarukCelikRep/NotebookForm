using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.DataAccess.Concrete.EntityFramework
{
    public class NotebookDbInitializer : DropCreateDatabaseAlways<NotebookContext>
    {
        protected override void Seed(NotebookContext context)
        {
            IList<User> defaultUser = new List<User>();
            IList<Password> adminPassword = new List<Password>();

            defaultUser.Add(new User
            {
                FirstName = "Faruk",
                LastName = "Celik",
                CreatedDate = DateTime.Now,
                UserName = "omerfaruk",
                IsActive = true,
                Role = UserRole.Admin
            });
            context.Users.AddRange(defaultUser);

            adminPassword.Add(new Password
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Text = "123",
                UserID = 1
            });

            context.Passwords.AddRange(adminPassword);

            base.Seed(context);
        }
    }
}
