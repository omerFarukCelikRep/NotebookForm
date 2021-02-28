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
        bool IsAdmin(string userName, string password);
        bool UserNameCheck(string userName);
        void ChangeState(string userName);
        List<User> GetInactiveUsers();
        int GetUserID(string userName);
    }
}
