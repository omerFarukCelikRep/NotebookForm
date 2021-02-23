using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.Entity.Abstract
{
    public interface IEntity
    {
        int ID { get; set; }
        bool IsActive { get; set; }
       DateTime CreatedDate { get; set; }
    }
}
