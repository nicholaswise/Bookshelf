using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]//<--Primary Key
        public int ID { get; set; }//<--When you are building a mode in C#, you will ALWAYS want an ID
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")]//<-- ForeignKey establishes relationship with another class (or table).
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } //<-- Navigation Property

    }
}