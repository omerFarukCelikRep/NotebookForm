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
    public class PasswordManager : IPasswordService
    {
        IPasswordDal _passwordDal;

        public PasswordManager(IPasswordDal passwordDal)
        {
            _passwordDal = passwordDal;
        }

        public void Add(Password entity)
        {
            _passwordDal.Add(entity);
        }

        public bool CheckLastPasswords(int userID, string password)
        {
            using (NotebookContext context = new NotebookContext())
            {
                var passwordList = context.Passwords.Where(p => p.UserID == userID).OrderByDescending(p => p.PasswordID).Take(3);

                if (passwordList.Any(p => p.Text == password))
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
        }

        public void Delete(Password entity)
        {
            _passwordDal.Delete(entity);
        }

        public List<Password> GetAll()
        {
            return _passwordDal.GetAll();
        }

        public void Update(Password entity)
        {
            _passwordDal.Update(entity);
        }
    }
}
