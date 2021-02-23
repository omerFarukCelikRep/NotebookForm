﻿using NotebookForm.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookForm.Entity.Concrete
{
    public class Password : BaseEntity
    {
        public string Text { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
