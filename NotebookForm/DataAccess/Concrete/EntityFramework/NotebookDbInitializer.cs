using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.DataAccess.Concrete.EntityFramework
{
    public class NotebookDbInitializer : CreateDatabaseIfNotExists<NotebookContext>
    {
        protected override void Seed(NotebookContext context)
        {
            User admin = new User();
            admin.FirstName = "Ömer Faruk";
            admin.LastName = "Celik";
            admin.CreatedDate = DateTime.Now;
            admin.UserName = "admin";
            admin.Role = UserRole.Admin;
            admin.IsActive = true;
            admin.Passwords.Add(new Password
            {
                Text = "123",
                CreatedDate = DateTime.Now,
                IsActive = true,
                
            });
            
            context.Users.Add(admin);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
