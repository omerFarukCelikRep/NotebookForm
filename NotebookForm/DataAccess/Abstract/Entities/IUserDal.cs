﻿using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.DataAccess.Abstract.Entities
{
    public interface IUserDal : IEntityRepository<User>
    {
        void ChangeState(string userName);
    }
}
