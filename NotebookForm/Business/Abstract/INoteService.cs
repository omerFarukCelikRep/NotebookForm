using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.Business.Abstract
{
    public interface INoteService : IService<Note>
    {
        List<Note> GetNotesByUser(int userID);
        bool IsExist(int noteID);
    }
}
