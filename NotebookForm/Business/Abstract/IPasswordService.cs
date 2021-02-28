using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.Business.Abstract
{
    public interface IPasswordService : IService<Password>
    {
        bool CheckLastPasswords(int userID, string password);
    }
}
