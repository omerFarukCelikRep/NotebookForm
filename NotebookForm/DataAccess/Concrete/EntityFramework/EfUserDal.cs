using NotebookForm.DataAccess.Abstract;
using NotebookForm.DataAccess.Abstract.Entities;
using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NotebookContext>, IUserDal
    {
        public override User Get(Expression<Func<User, bool>> filter)
        {
            using (NotebookContext context = new NotebookContext())
            {
                return context.Users.SingleOrDefault(filter);
            }
        }
        public void ChangeState(string userName)
        {
            using (NotebookContext context = new NotebookContext())
            {
                User user = Get(a => a.UserName == userName);
                if (user.IsActive)
                {
                    user.IsActive = false;
                }
                else
                {
                    user.IsActive = true;
                }
                Update(user);
            }
        }
    }
}
