using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrubakerMIS4200.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Display(Name = "Book Name")]
        public string bookName { get; set; }
        [Display(Name = "Book Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime releaseDate { get; set; }
        [Display(Name ="Cost of Book")]
        [DataType(DataType.Currency)]

        public decimal Cost { get; set; }
        [Display(Name ="Name of Author")]
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
        [Display(Name ="Name of Publisher")]
        public int PublisherID { get; set; }
        public virtual Publisher Publisher { get; set; }


    }
}