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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User entity)
        {
            _userDal.Add(entity);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public bool LoginCheck(string userName, string password)
        {
            if (_userDal.GetUserDetails().Any(u => u.UserName == userName && u.Password == password))
            {
                return true;
            }
            else
            {
                throw new Exception("Kullanıcı Bulunamadı");
            }
        }

        public void Update(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
