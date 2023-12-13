using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.Models
{
    internal class GroupClass
    {
        public GroupClass()
        { 
            this.Accounts = new HashSet<Account>();
        }
        [Key]
        public string GroupClassID { get; set; }
        public string GroupName { get; set; }
        [ForeignKey(nameof(Faculty))]
        public string FacultyID { get; set; }
        [InverseProperty("GroupClass")]
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
