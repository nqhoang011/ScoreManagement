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
    public partial class fEditSubject1 : Form
    {
        string subjectID;
        EFDbContext db = new EFDbContext();
        public fEditSubject1(string SubjectID)
        {
            InitializeComponent();
            subjectID = SubjectID;
        }

        private void fEditSubject1_Load(object sender, EventArgs e)
        {
            Subject subject = db.Subjects.Single(c => c.SubjectID == Convert.ToInt64(subjectID));
            txtSubjectName.Text = subject.SubjectName;
            cbFaculty.ValueMember = "FacultyID";
            cbFaculty.DisplayMember = "FacultyName";
            cbFaculty.DataSource = db.Faculties.Select(p => new
            {
                p.FacultyID,
                p.FacultyName
            }).ToList();
            cbFaculty.Text = db.Faculties.Single(c => c.FacultyID.Equals(subject.FacultyID)).FacultyName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Subject subject = db.Subjects.Single(c => c.SubjectID.Equals(subjectID));
                subject.SubjectName = txtSubjectName.Text;
                subject.FacultyID = cbFaculty.SelectedValue.ToString();
                db.SaveChanges();
                MessageBox.Show("Lưu thay đổi thành công!", "Thành công", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thay đổi thất bại! Error: " + ex.Message, "Thất bại", MessageBoxButtons.OK);
            }
        }
    }
}
