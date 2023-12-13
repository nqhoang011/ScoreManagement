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
using static System.Formats.Asn1.AsnWriter;

namespace ScoreManagement
{
    public partial class fEditScore : Form
    {
        EFDbContext db = new EFDbContext();
        string studentID;
        string classSubjectID;
        public fEditScore(string studentID, string classSubjectID)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.classSubjectID = classSubjectID;
        }

        private void fEditScore_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(studentID + " " + classSubjectID);
            Score score = db.Scores.Single(c => c.AccountID.Equals(studentID) &&
                c.ClassSubjectID.Equals(classSubjectID));
            txtMidtermScore.Text = score.MidtermScore.ToString();
            txtFinalScore.Text = score.FinalScore.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMidtermScore.Text))
            {
                toolTip1.Show("Chưa nhập điểm quá trình!", txtMidtermScore, 0, 0, 2000);
                txtMidtermScore.Focus();
                return;
            }
            if(!double.TryParse(txtMidtermScore.Text, out _))
            {
                toolTip1.Show("Điểm giữa kì phải là số thực!", txtMidtermScore, 0, 0, 2000);
                txtMidtermScore.Focus();
                return;
            }
            if(!double.TryParse(txtFinalScore.Text, out _))
            {
                toolTip1.Show("Điểm cuối kì phải là số thực!", txtFinalScore, 0, 0, 2000);
                txtFinalScore.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMidtermScore.Text))
            {
                toolTip1.Show("Chưa nhập điểm quá trình!", txtMidtermScore, 0, 0, 2000);
                txtMidtermScore.Focus();
                return;
            }
            if (Convert.ToDouble(txtMidtermScore.Text) < 0.0 || Convert.ToDouble(txtMidtermScore.Text) > 10.0)
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
            Score score = db.Scores.Single(c => c.AccountID.Equals(studentID) &&
                c.ClassSubjectID.Equals(classSubjectID));
            try
            {
                score.MidtermScore = Convert.ToDouble(txtMidtermScore.Text);
                score.FinalScore = Convert.ToDouble(txtFinalScore.Text);
                db.SaveChanges();
                MessageBox.Show("Lưu thay đổi thành công!", "Thành công", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại! Error: " + ex.Message, "Thất bại", MessageBoxButtons.OK);
                return;
            }
            Close();
        }
    }
}
