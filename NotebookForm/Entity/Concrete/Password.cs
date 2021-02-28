using NotebookForm.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.Entity.Concrete
{
    public class Password : BaseEntity
    {
        public int PasswordID { get; set; }
        public string Text { get; set; }
        public int UserID { get; set; }

        //Navigation Prop
        public virtual User User { get; set; }
    }
}
