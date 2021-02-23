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
    public class NoteMapping : EntityTypeConfiguration<Note>
    {
        public NoteMapping()
        {
            HasKey(k => k.ID);

            Property(k => k.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.CreatedDate)
                .IsRequired();

            Property(p => p.Content)
                .IsOptional();

            Property(p => p.IsActive)
                .IsRequired();

            Property(p => p.Title)
                .IsRequired();

            HasRequired(r => r.User)
                .WithMany(m => m.Notes)
                .HasForeignKey(f => f.UserID);

            Map(m => m.MapInheritedProperties());
        }
    }
}
