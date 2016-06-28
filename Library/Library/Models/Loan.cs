//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }

        public DateTime ? TimeofLoan { get; set; }
        public DateTime ? DueDate { get; set; }
        public DateTime ? ReturnTime { get; set; }
        
        public int BookCopyId { get; set; }
        public int MemberId { get; set; }
        public virtual BookCopy BookCopy { get; set; }
        public virtual Member Member { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", this.BookCopy);
        }
    }
}
