//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int ISBN { get; set; }
        public string Description { get; set; }

        // A book has a referens to an author-object and then the
        // Book-table will contain a foreign key to the Author-table
      
        public virtual Author Author { get; set; }
        public virtual ICollection<BookCopy> BookCopies { get; set; }

        public override string ToString() {
            return String.Format("[{0}] -- {1}", this.Id, this.Title);
        }
    }
}