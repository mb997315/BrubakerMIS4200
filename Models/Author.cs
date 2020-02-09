﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrubakerMIS4200.Models
{
    public class Author
    {
        public int authorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}