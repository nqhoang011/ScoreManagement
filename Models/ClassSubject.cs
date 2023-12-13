using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.Models
{
    internal class ClassSubject
    {
        public ClassSubject()
        {
            this.Scores = new HashSet<Score>();
        }
        public string ClassSubjectID { get; set; }
        public string ClassName { get; set; }
        public int SubjectID { get; set; }
        [InverseProperty("ClassSubject")]
        public virtual ICollection<Score> Scores { get; set; }
    }
}
