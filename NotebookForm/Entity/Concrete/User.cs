using NotebookForm.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.Entity.Concrete
{
    public enum UserRole
    {
        Admin = 1,
        User
    }
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public UserRole Role { get; set; }
        public ICollection<Password> Passwords { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
