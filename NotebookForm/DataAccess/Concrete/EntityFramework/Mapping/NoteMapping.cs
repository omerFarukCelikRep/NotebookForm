using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
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

        }
    }
}
