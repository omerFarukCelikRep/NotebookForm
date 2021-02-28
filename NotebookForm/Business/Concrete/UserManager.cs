using NotebookForm.Business.Abstract;
using NotebookForm.DataAccess.Abstract.Entities;
using NotebookForm.DataAccess.Concrete.EntityFramework;
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

        public void ChangeState(string userName)
        {
            _userDal.ChangeState(userName);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public List<User> GetInactiveUsers()
        {
            using (NotebookContext context = new NotebookContext())
            {
                return context.Users.Where(u => u.IsActive == false).ToList();
            }
        }

        public int GetUserID(string userName)
        {
            return _userDal.Get(u => u.UserName == userName).UserID;
        }

        public bool IsAdmin(string userName, string password)
        {
            using (NotebookContext context = new NotebookContext())
            {
                var userList = context.Passwords.Join(context.Users,
                    p => p.UserID,
                    u => u.UserID,
                    (p, u) => new
                    {
                        u.UserID,
                        u.UserName,
                        p.Text,
                        u.IsActive,
                        u.Role
                    });
                if (userList.Any(u => u.UserName == userName && u.Text == password))
                {
                    var user = userList.SingleOrDefault(u => u.UserName == userName && u.Text == password);

                    return user.Role == UserRole.Admin ? true : false;


                }
                else
                {
                    return false;
                }
            }
        }

        public bool LoginCheck(string userName, string password)
        {
            using (NotebookContext context = new NotebookContext())
            {
                var userList = context.Passwords.Join(context.Users,
                    p => p.UserID,
                    u => u.UserID,
                    (p, u) => new
                    {
                        u.UserID,
                        u.UserName,
                        p.Text,
                        u.IsActive
                    });
                if (userList.Any(u => u.UserName == userName && u.Text == password))
                {
                    var user = userList.SingleOrDefault(u => u.UserName == userName && u.Text == password);

                    return user.IsActive == true ? true : throw new Exception("Kullanıcı Onaylanmamış veya Aktif Değil");


                }
                else
                {
                    throw new Exception("Kullanıcı Bulunamadı");
                }
            }
            
        }

        public void Update(User entity)
        {
            _userDal.Update(entity);
        }

        public bool UserNameCheck(string userName)
        {
            if (_userDal.GetAll().Any(u => u.UserName == userName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
