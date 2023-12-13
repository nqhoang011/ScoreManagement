using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreManagement.Models;

namespace ScoreManagement
{
    public partial class fMainStudent : Form
    {
        EFDbContext db = new EFDbContext();
        string AccountID;
        Faculty faculty;
        GroupClass groupClass;
        Account account;
        public fMainStudent(string AccountID)
        {
            InitializeComponent();
            this.AccountID = AccountID;
        }
        private void fMainStudent_Load(object sender, EventArgs e)
        {
            account = db.Accounts.Single(p => p.AccountID == AccountID);
            groupClass = db.GroupClasses.Single(p => p.Accounts.Single(p2 => p2.AccountID == AccountID) != null);
            faculty = db.Faculties.Single(p => p.GroupClasses.Single(p2 => p2.GroupClassID == groupClass.GroupClassID) != null);

            txtName.Text = account.Name;
            txtStudentID.Text = account.AccountID;
            txtGender.Text = (account.Gender == true ? "Nam" : account.Gender == false ? "Nữ" : "Khác");
            dtDateOfBirth.Text = account.DateOfBirth.ToString();
            txtFaculty.Text = faculty.FacultyName;
            txtClass.Text = groupClass.GroupName;

            dataGridView1.DataSource = db.Scores.Where(o => o.AccountID == AccountID).Select(o => new
            {
                o.SubjectID,
                o.ClassSubjectID,
                SubjectName = o.Subject.SubjectName,
                o.MidtermScore,
                o.FinalScore,
                o.AverageScore,
                Failed = (o.AverageScore >= 4.0 ? false : true)
            }).ToList();
        }

        private void fMainStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fEditStudentInfo"))
            {
                fEditStudentInfo f = new fEditStudentInfo(AccountID);
                f.Show();
            }
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fEditStudentInfo"))
            {
                fEditStudentInfo f = new fEditStudentInfo(AccountID);
                f.Show();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fChangePassword"))
            {
                fChangePassword f = new fChangePassword(AccountID);
                f.Show();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin f = new fLogin();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
