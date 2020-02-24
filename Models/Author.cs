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
        public string fullName { get { return lastName + ", " + firstName; } }
        [Display (Name ="First Name")]
       [Required]
       [StringLength(20)]
       
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
       [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter your Email Please")]
        public string email { get; set; }
        public ICollection<Book> Book { get; set; }
        
    }
}