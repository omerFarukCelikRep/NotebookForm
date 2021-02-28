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
    public class PasswordMapping : EntityTypeConfiguration<Password>
    {
        public PasswordMapping()
        {
            HasKey(k => k.PasswordID);

            Property(k => k.PasswordID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Text)
                .HasMaxLength(16)
                .HasColumnType("varchar")
                .IsRequired();

            Property(p => p.CreatedDate)
                .IsRequired();

            Property(p => p.IsActive)
                .IsRequired();

            Property(p => p.ModifiedDate)
                .IsOptional();

            HasRequired(r => r.User)
                .WithMany(m => m.Passwords)
                .HasForeignKey(f => f.UserID);

            Map(m => m.MapInheritedProperties());
        }
    }
}
