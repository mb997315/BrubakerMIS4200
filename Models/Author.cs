using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrubakerMIS4200.Models
{
    public class Author
    {
        public int authorID { get; set; }
        [Display (Name ="First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}