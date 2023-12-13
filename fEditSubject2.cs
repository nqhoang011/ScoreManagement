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
    public partial class fEditSubject2 : Form
    {
        string subjectID;
        EFDbContext db = new EFDbContext();
        public fEditSubject2(string SubjectID)
        {
            InitializeComponent();
            subjectID = SubjectID;
        }

        private void fEditSubject2_Load(object sender, EventArgs e)
        {
            Subject subject = db.Subjects.Single(c => c.SubjectID == Convert.ToInt64(subjectID));
            txtSubjectName.Text = subject.SubjectName;
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
