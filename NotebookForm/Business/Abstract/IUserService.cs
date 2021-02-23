using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.Business.Abstract
{
    public interface IUserService : IService<User>
    {
        bool LoginCheck(string userName, string password);

    }
}
