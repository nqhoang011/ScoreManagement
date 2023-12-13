using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.Models
{
    internal class Score
    {
        public long ScoreID { get; set; }
        public double MidtermScore { get; set; }
        public double FinalScore { get; set; }
        public double AverageScore { get { return (MidtermScore + FinalScore) / 2.0; } }
        [ForeignKey(nameof(Account))]
        public string AccountID { get; set; }
        [ForeignKey(nameof(Subject))]
        public long SubjectID { get; set; }
        [ForeignKey(nameof(ClassSubject))]
        public string ClassSubjectID { get; set; }
        [InverseProperty("Scores")]
        public virtual Account Account { get; set; }
        [InverseProperty("Scores")]
        public virtual Subject Subject { get; set; }
        [InverseProperty("Scores")]
        public virtual ClassSubject ClassSubject { get; set; }
    }
}
