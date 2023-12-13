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
    public partial class FCreateTranscript : Form
    {
        EFDbContext db = new EFDbContext();
        public FCreateTranscript()
        {
            InitializeComponent();
        }

        private void FCreateTranscript_Load(object sender, EventArgs e)
        {
            cbFacultyName.ValueMember = "FacultyID";
            cbFacultyName.DisplayMember = "FacultyName";
            cbFacultyName.DataSource = db.Faculties.Select(p => new
            {
                p.FacultyID,
                p.FacultyName
            }).ToList();
            cbFacultyName.Text = null;
        }

        private void cbFacultyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubjectName.DisplayMember = "SubjectName";
            cbSubjectName.ValueMember = "SubjectID";
            cbSubjectName.DataSource = db.Subjects.Where(o => o.FacultyID == cbFacultyName.SelectedValue)
                .Select(p => new { p.SubjectID, p.SubjectName }).ToList();
            cbSubjectName.Text = null;
        }

        private void cbSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClassSubjectName.DisplayMember = "ClassName";
            cbClassSubjectName.ValueMember = "ClassSubjectID";
            cbClassSubjectName.DataSource = db.ClassSubjects.Where(c => c.SubjectID.Equals(cbSubjectName.SelectedValue)).Select(p => new
            {
                p.ClassSubjectID,
                p.ClassName
            }).ToList();
            cbClassSubjectName.Text = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string classSubjectName = cbClassSubjectName.Text;
            string subjectName = cbSubjectName.Text;
            if (!Utility.IsOpeningForm("fReportTranscript"))
            {
                fReportTranscript f = new fReportTranscript(classSubjectName, subjectName);
                //f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
