//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        public string PersonalId { get; set; }
        public string Name { get; set; }
        public ICollection<Loan> Loans { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.Id, this.Name);
        }
    }
}
