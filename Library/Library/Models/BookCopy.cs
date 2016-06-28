//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookCopy
    {
        public int Id { get; set; }
        public virtual Book Book { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", this.Book);
        }
    }
}
