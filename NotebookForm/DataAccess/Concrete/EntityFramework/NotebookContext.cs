using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.DataAccess.Concrete.EntityFramework
{
    public class NotebookContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Note> Notes { get; set; }
        public NotebookContext() : base("name=notebookConnString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}
