﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models
{
    public class BookViewModel
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual string ISBN { get; set; }
        public virtual string Website { get; set; }
        public virtual string Description { get; set; }
        public virtual int Category { get; set; }
    }
}