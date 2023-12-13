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
    public partial class fNewManageScore : Form
    {
        EFDbContext db = new EFDbContext();
        string FacultyID;
        string SubjectID;
        string ClassSubjectID;
        public fNewManageScore(string FacultyID, string SubjectID, string ClassSubjectID)
        {
            InitializeComponent();
            this.FacultyID = FacultyID;
            this.SubjectID = SubjectID;
            this.ClassSubjectID = ClassSubjectID;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                toolTip1.Show("Chưa nhập mã số sinh viên!", txtStudentID, 0, 0, 2000);
                txtStudentID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                toolTip1.Show("Mã sinh viên bị sai!", txtStudentID, 0, 0, 2000);
                txtStudentID.Focus();
                return;
            }
            if (db.Scores.SingleOrDefault(c => c.ClassSubjectID.Equals(cbClassName.SelectedValue) && c.AccountID.Equals(txtStudentID.Text)) != null)
            {
                toolTip1.Show("Sinh viên đã có điểm môn này!", btSave, 0, 0, 2000);
                return;
            }
            if(string.IsNullOrWhiteSpace(txtMidtermScore.Text))
            {
                toolTip1.Show("Chưa nhập điểm giữa kì!", txtMidtermScore, 0, 0, 2000);
                txtMidtermScore.Focus();
                return;
            }
            if (!double.TryParse(txtMidtermScore.Text, out _))
            {
                toolTip1.Show("Điểm giữa kì phải là kiểu số thực!", txtMidtermScore, 0, 0, 2000);
                txtMidtermScore.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtFinalScore.Text))
            {
                toolTip1.Show("Chưa nhập điểm cuối kì!", txtFinalScore, 0, 0, 2000);
                txtFinalScore.Focus();
                return;
            }
            if (!double.TryParse(txtFinalScore.Text, out _))
            {
                toolTip1.Show("Điểm giữa kì phải là kiểu số thực!", txtFinalScore, 0, 0, 2000);
                txtFinalScore.Focus();
                return;
            }
            if(Convert.ToDouble(txtMidtermScore.Text) < 0.0 || Convert.ToDouble(txtMidtermScore.Text) > 10.0)
            {
                toolTip1.Show("Điểm phải nằm trong khoảng [0, 10]", txtMidtermScore, 0, 0, 2000);
                txtMidtermScore.Focus();
                return;
            }
            if (Convert.ToDouble(txtFinalScore.Text) < 0.0 || Convert.ToDouble(txtFinalScore.Text) > 10.0)
            {
                toolTip1.Show("Điểm phải nằm trong khoảng [0, 10]", txtFinalScore, 0, 0, 2000);
                txtFinalScore.Focus();
                return;
            }
            try
            {
                Score score = new Score();
                score.MidtermScore = Convert.ToDouble(txtMidtermScore.Text);
                score.FinalScore = Convert.ToDouble(txtFinalScore.Text);
                score.AccountID = txtStudentID.Text;
                score.SubjectID = Convert.ToInt64(cbSubjectName.SelectedValue);
                score.ClassSubjectID = cbClassName.SelectedValue.ToString();
                db.Scores.Add(score);
                db.SaveChanges();
                toolTip1.Show("Thêm thành công!", btSave, 0, 0, 2000);
                txtStudentID.Text = null;
                txtStudentName.Text = null;
                txtMidtermScore.Text = null;
                txtFinalScore.Text = null;
            }
            catch (Exception ex)
            {
                toolTip1.Show("Thêm thất bại! Error: " + ex.Message, btSave, 0, 0, 2000);
            }
        }

        private void fNewManageScore_Load(object sender, EventArgs e)
        {
            cbFaculty.DisplayMember = "FacultyName";
            cbFaculty.ValueMember = "FacultyID";
            cbFaculty.DataSource = db.Faculties.Select(p => new
            {
                p.FacultyName,
                p.FacultyID
            }).ToList();
            if (FacultyID != null)
            {
                cbFaculty.SelectedItem = cbFaculty.Items.Cast<dynamic>().Single(c => c.FacultyID.Equals(FacultyID));
            }
            else
            {
                cbFaculty.SelectedItem = null;
            }
            //cbFaculty_SelectedIndexChanged(sender, e);
            //cbSubjectName_SelectedIndexChanged(sender, e);
        }

        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubjectName.DisplayMember = "SubjectName";
            cbSubjectName.ValueMember = "SubjectID";
            cbSubjectName.DataSource = db.Subjects.Where(o => o.FacultyID.Equals(cbFaculty.SelectedValue))
                .Select(p => new { p.SubjectID, p.SubjectName }).ToList();
            //MessageBox.Show(SubjectID);
            /*if (this.SubjectID != null)
            {
                cbSubjectName.SelectedItem = cbSubjectName.Items.Cast<dynamic>().Single(p => p.SubjectID == Convert.ToInt64(this.SubjectID));
            }
            else
            {
                cbSubjectName.SelectedItem = null;
            }*/
            cbSubjectName_SelectedIndexChanged(sender, e);
        }
        private void cbSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClassName.DisplayMember = "ClassName";
            cbClassName.ValueMember = "ClassSubjectID";
            cbClassName.DataSource = db.ClassSubjects.Where(o => o.SubjectID == Convert.ToInt64(cbSubjectName.SelectedValue))
                .Select(p => new { p.ClassSubjectID, p.ClassName }).ToList();
            if (this.ClassSubjectID != null)
            {
                cbClassName.SelectedItem = cbClassName.Items.Cast<dynamic>().SingleOrDefault(c => c.ClassSubjectID.Equals(this.ClassSubjectID));
            }
            else
            {
                cbClassName.SelectedItem = null;
            }
        }

        private void fNewManageScore_Activated(object sender, EventArgs e)
        {
            fNewManageScore_Load(sender, e);
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (db.Accounts.SingleOrDefault(c => c.AccountID.Equals(txtStudentID.Text)) != null)
            {
                txtStudentName.Text = db.Accounts.Single(c => c.AccountID == txtStudentID.Text).Name;
            }
        }
    }
}
