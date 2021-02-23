using NotebookForm.DataAccess.Abstract;
using NotebookForm.DataAccess.Abstract.Entities;
using NotebookForm.Entity.Concrete;
using NotebookForm.Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NotebookContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (NotebookContext context = new NotebookContext())
            {
                var result = context.Passwords.Join(context.Users,
                    p => p.UserID,
                    u => u.ID,
                    (p, u) => new UserDetailDto
                    {
                        UserID = u.ID,
                        UserName = u.UserName,
                        Password = p.Text
                    });
                return result.ToList();
            }
        }
    }
}
