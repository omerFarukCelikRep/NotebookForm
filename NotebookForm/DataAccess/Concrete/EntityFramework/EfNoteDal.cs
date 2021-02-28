using NotebookForm.DataAccess.Abstract;
using NotebookForm.DataAccess.Abstract.Entities;
using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.DataAccess.Concrete.EntityFramework
{
    public class EfNoteDal : EfEntityRepositoryBase<Note, NotebookContext>, INoteDal
    {
        public override void Delete(Note entity)
        {
            using (NotebookContext context = new NotebookContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<Note> GetNotesByUser(int userID)
        {
            using (NotebookContext context = new NotebookContext())
            {
                return context.Notes.Where(n => n.UserID == userID).ToList();
            }
        }
    }
}
