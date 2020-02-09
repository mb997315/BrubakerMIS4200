using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrubakerMIS4200.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Adress { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}