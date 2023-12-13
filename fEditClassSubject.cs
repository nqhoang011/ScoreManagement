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
    public partial class fEditClassSubject : Form
    {
        long subjectID;
        string classSubjectID;
        EFDbContext db = new EFDbContext();
        public fEditClassSubject(long SubjectID, string ClassSubjectID)
        {
            InitializeComponent();
            subjectID = SubjectID;
            classSubjectID = ClassSubjectID;
        }

        private void fEditClassSubject_Load(object sender, EventArgs e)
        {
            ClassSubject classSubject = db.ClassSubjects.Single(c => c.SubjectID == subjectID && c.ClassSubjectID.Equals(classSubjectID));
            txtClassSubjectID.Text = classSubjectID;
            txtClassSubjectName.Text = classSubject.ClassName;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            ClassSubject classSubject = db.ClassSubjects.Single(c => c.SubjectID == subjectID && c.ClassSubjectID.Equals(classSubjectID));
            classSubject.ClassSubjectID = txtClassSubjectID.Text;
            classSubject.ClassName = txtClassSubjectName.Text;
            try
            {
                db.SaveChanges();
                MessageBox.Show("Lưu thành công!", "Thành công", MessageBoxButtons.OK);
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
