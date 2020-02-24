using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrubakerMIS4200.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        [Display(Name ="Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
       [StringLength(2, MinimumLength =2, ErrorMessage ="State must be two Charcters")]
        public string State { get; set; }
        [Display(Name = "Address")]
        public string Adress { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}