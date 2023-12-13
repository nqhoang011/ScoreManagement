using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.Models
{
    internal class Subject
    {
        public Subject()
        {
            this.Scores = new HashSet<Score>();
        }
        [Key]
        public long SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string FacultyID { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<Score> Scores { get; set; }

    }
}
