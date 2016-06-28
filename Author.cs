//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        // A author may have written several books, one-to-many
        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.Id, this.Name);
        }
    }
}
