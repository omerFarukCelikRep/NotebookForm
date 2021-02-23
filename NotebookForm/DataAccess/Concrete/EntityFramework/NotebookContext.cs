using NotebookForm.DataAccess.Concrete.EntityFramework.Mapping;
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
        public NotebookContext() : base("Server=.; Database=Notebooks; Trusted_Connection=true")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new PasswordMapping());
            modelBuilder.Configurations.Add(new NoteMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}
