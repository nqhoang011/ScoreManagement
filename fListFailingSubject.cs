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
    public partial class fListFailingSubject : Form
    {
        EFDbContext db = new EFDbContext();
        public fListFailingSubject()
        {
            InitializeComponent();
        }

        private void fListFailingSubject_Load(object sender, EventArgs e)
        {
            cbFaculty.DisplayMember = "FacultyName";
            cbFaculty.ValueMember = "FacultyID";
            cbFaculty.DataSource = db.Faculties.Select(p => new
            {
                p.FacultyName,
                p.FacultyID
            }).ToList();
            cbFaculty.Text = null;
            dataGridView1.DataSource = db.Scores
                .OrderBy(c => c.Account.Name)
                .Where(c => (c.MidtermScore + c.FinalScore) / 2.0 < 4.0)
                .Select(p => new
                {
                    StudentID = p.AccountID,
                    StudentName = p.Account.Name,
                    GroupName = p.Account.GroupClass.GroupName,
                    p.Subject.SubjectName,
                    AverageScore = (p.MidtermScore + p.FinalScore) / 2.0,
                    Failed = true
                }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbFaculty.SelectedItem == null)
            {
                dataGridView1.DataSource = db.Scores
                    .Where(c => (c.MidtermScore + c.FinalScore) / 2.0 < 4.0
                    && c.AccountID.Contains(txtStudentID.Text))
                    .Select(p => new
                    {
                        p.AccountID,
                        p.Account.Name,
                        p.Account.GroupClassID,
                        p.Subject.SubjectName,
                        AverageScore = (p.MidtermScore + p.FinalScore) / 2.0,
                        Failed = true
                    }).ToList();
            }
            else
            {
                if (cbSubjectName.SelectedItem == null)
                {
                    dataGridView1.DataSource = db.Scores
                    .Where(c => (c.MidtermScore + c.FinalScore) / 2.0 < 4.0
                    && c.AccountID.Contains(txtStudentID.Text))
                    .Select(p => new
                    {
                        p.AccountID,
                        p.Account.Name,
                        p.Account.GroupClassID,
                        p.Subject.SubjectName,
                        AverageScore = (p.MidtermScore + p.FinalScore) / 2.0,
                        Failed = true
                    }).ToList();
                }
                else
                {
                    if (cbClassSubject.SelectedItem == null)
                    {
                        dataGridView1.DataSource = db.Scores
                        .Where(c => (c.MidtermScore + c.FinalScore) / 2.0 < 4.0
                        && c.AccountID.Contains(txtStudentID.Text)
                        && c.SubjectID == Convert.ToInt64(cbSubjectName.SelectedValue))
                        .Select(p => new
                        {
                            p.AccountID,
                            p.Account.Name,
                            p.Account.GroupClassID,
                            p.Subject.SubjectName,
                            AverageScore = (p.MidtermScore + p.FinalScore) / 2.0,
                            Failed = true
                        }).ToList();
                    }
                    else
                    {
                        dataGridView1.DataSource = db.Scores
                        .Where(c => (c.MidtermScore + c.FinalScore) / 2.0 < 4.0
                        && c.AccountID.Contains(txtStudentID.Text)
                        && c.ClassSubjectID.Equals(cbSubjectName.SelectedValue)
                        && c.ClassSubjectID.Equals(cbClassSubject.SelectedValue))
                        .Select(p => new
                        {
                            p.AccountID,
                            p.Account.Name,
                            p.Account.GroupClassID,
                            p.Subject.SubjectName,
                            AverageScore = (p.MidtermScore + p.FinalScore) / 2.0,
                            Failed = true
                        }).ToList();
                    }
                }

            }

        }

        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubjectName.DisplayMember = "SubjectName";
            cbSubjectName.ValueMember = "SubjectID";
            cbSubjectName.DataSource = db.Subjects.Where(o => o.FacultyID == cbFaculty.SelectedValue)
                .Select(p => new { p.SubjectID, p.SubjectName }).ToList();
            cbSubjectName.Text = null;
            dataGridView1.DataSource = db.Scores
                .OrderBy(c => c.Account.Name)
                .Where(c => (c.MidtermScore + c.FinalScore) / 2.0 < 4.0
                && c.Subject.FacultyID.Equals(cbFaculty.SelectedValue))
                .Select(p => new
                {
                    StudentID = p.AccountID,
                    StudentName = p.Account.Name,
                    GroupName = p.Account.GroupClass.GroupName,
                    p.Subject.SubjectName,
                    AverageScore = (p.MidtermScore + p.FinalScore) / 2.0,
                    Failed = true
                }).ToList();
        }

        private void cbSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClassSubject.DisplayMember = "ClassName";
            cbClassSubject.ValueMember = "ClassSubjectID";
            cbClassSubject.DataSource = db.ClassSubjects.Where(o => o.SubjectID == Convert.ToInt64(cbSubjectName.SelectedValue))
                .Select(p => new { p.ClassSubjectID, p.ClassName }).ToList();
            cbClassSubject.Text = null;
            dataGridView1.DataSource = db.Scores
                .OrderBy(c => c.Account.Name)
                .Where(c => (c.MidtermScore + c.FinalScore) / 2.0 < 4.0
                && c.Subject.FacultyID.Equals(cbFaculty.SelectedValue)
                && c.SubjectID == Convert.ToInt64(cbSubjectName.SelectedValue))
                .Select(p => new
                {
                    StudentID = p.AccountID,
                    StudentName = p.Account.Name,
                    GroupName = p.Account.GroupClass.GroupName,
                    p.Subject.SubjectName,
                    AverageScore = (p.MidtermScore + p.FinalScore) / 2.0,
                    Failed = true
                }).ToList();
        }

        private void cbClassSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Scores
                .OrderBy(c => c.Account.Name)
                .Where(c => (c.MidtermScore + c.FinalScore) / 2.0 < 4.0
                && c.Subject.FacultyID.Equals(cbFaculty.SelectedValue)
                && c.SubjectID == Convert.ToInt64(cbSubjectName.SelectedValue)
                && c.ClassSubjectID.Equals(cbClassSubject.SelectedValue))
                .Select(p => new
                {
                    StudentID = p.AccountID,
                    StudentName = p.Account.Name,
                    GroupName = p.Account.GroupClass.GroupName,
                    p.Subject.SubjectName,
                    AverageScore = (p.MidtermScore + p.FinalScore) / 2.0,
                    Failed = true
                }).ToList();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            string classSubjectName = cbSubjectName.Text;
            string subjectName = cbClassSubject.Text;
            //MessageBox.Show(classSubjectName + " " + subjectName);
            if (!Utility.IsOpeningForm("fReportFailingScore"))
            {
                fReportFailingScore f = new fReportFailingScore(subjectName, classSubjectName);
                //f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
