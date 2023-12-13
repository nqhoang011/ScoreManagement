using ScoreManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement
{
    public partial class fLookUpScore : Form
    {
        EFDbContext db = new EFDbContext();
        public fLookUpScore()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Scores.Where(c => c.AccountID.Equals(txtStudentID.Text)).Select(p => new
            {
                MSSV = p.AccountID,
                StudentName = p.Account.Name,
                p.Subject.SubjectName,
                p.MidtermScore,
                p.FinalScore,
                AverageScore = Convert.ToString((p.MidtermScore + p.FinalScore) / 2.0),
                Failed = ((p.MidtermScore + p.FinalScore) / 2.0 < 4.0 ? true : false)
            }).ToList();
        }
    }
}
