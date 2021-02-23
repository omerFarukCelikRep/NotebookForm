using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(k => k.ID);

            Property(p => p.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.CreatedDate)
                .IsRequired();

            Property(p => p.Role)
                .IsRequired();

            Property(p => p.IsActive)
                .IsRequired();

            Property(p => p.UserName)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .IsRequired();

            HasMany(p => p.Passwords)
                .WithRequired(u => u.User)
                .HasForeignKey(u => u.UserID);

            Map(m => m.MapInheritedProperties());
        }
    }
}
