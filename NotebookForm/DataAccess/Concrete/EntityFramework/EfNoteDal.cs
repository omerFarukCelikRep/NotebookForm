using NotebookForm.DataAccess.Abstract;
using NotebookForm.DataAccess.Abstract.Entities;
using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.DataAccess.Concrete.EntityFramework
{
    public class EfNoteDal : EfEntityRepositoryBase<Note, NotebookContext>, INoteDal
    {
    }
}
