using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.Models
{
    internal class Account
    {
        public Account()
        {
            this.Scores = new HashSet<Score>();
        }
        public string AccountID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey(nameof(GroupClass))]
        public string GroupClassID { get; set;}
        [InverseProperty("Account")]
        public virtual ICollection<Score> Scores { get; set; }
        public virtual GroupClass GroupClass { get; set; }

    }
}
