using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.Models
{
    internal class Faculty
    {
        public Faculty()
        {
            this.GroupClasses = new HashSet<GroupClass>();
        }
        [Key]
        public string FacultyID { get; set; }
        public string FacultyName { get; set; }
        [InverseProperty("Faculty")]
        public virtual ICollection<GroupClass> GroupClasses { get; set; }
    }
}
