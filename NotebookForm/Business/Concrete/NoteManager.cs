using NotebookForm.Business.Abstract;
using NotebookForm.DataAccess.Abstract.Entities;
using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.Business.Concrete
{
    public class NoteManager : INoteService
    {
        INoteDal _noteDal;

        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        public void Add(Note entity)
        {
            _noteDal.Add(entity);
        }

        public void Delete(Note entity)
        {
            _noteDal.Delete(entity);
        }

        public List<Note> GetAll()
        {
            return _noteDal.GetAll();
        }

        public List<Note> GetNotesByUser(int userID)
        {
            return _noteDal.GetNotesByUser(userID);
        }

        public bool IsExist(int noteID)
        {
            if (GetAll().Any(n => n.NoteID == noteID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(Note entity)
        {
            _noteDal.Update(entity);
        }
    }
}
