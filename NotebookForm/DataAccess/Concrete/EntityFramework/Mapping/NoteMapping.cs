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
            HasKey(k => k.NoteID);

            Property(k => k.NoteID)
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

            // kalıtım alınana classtaki propertyler diğer tüm tablolarda kolon olarak oluşur
            Map(m => m.MapInheritedProperties());
        }
    }
}
