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
    public partial class fManageClassSubject : Form
    {
        EFDbContext db = new EFDbContext();
        public fManageClassSubject()
        {
            InitializeComponent();
        }

        private void fManageClassSubject_Load(object sender, EventArgs e)
        {
            cbFacultyName.ValueMember = "FacultyID";
            cbFacultyName.DisplayMember = "FacultyName";
            cbFacultyName.DataSource = db.Faculties.Select(p => new
            {
                p.FacultyID,
                p.FacultyName
            }).ToList();
            cbFacultyName.Text = null;
            cbFindFaculty.ValueMember = "FacultyID";
            cbFindFaculty.DisplayMember = "FacultyName";
            cbFindFaculty.DataSource = db.Faculties.Select(p => new
            {
                p.FacultyID,
                p.FacultyName
            }).ToList();
            cbFindFaculty.Text = null;
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
            if (cbSubjectName.SelectedValue != null)
            {
                txtClassSubjectID.Text = cbSubjectName.SelectedValue.ToString();
            }
            else
            {
                txtClassSubjectID.Text = null;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClassSubject classSubject = new ClassSubject();
            classSubject.ClassSubjectID = txtClassSubjectID.Text;
            classSubject.ClassName = txtClassSubjectName.Text;
            classSubject.SubjectID = Convert.ToInt32(cbSubjectName.SelectedValue);
            try
            {
                db.ClassSubjects.Add(classSubject);
                db.SaveChanges();
                fManageClassSubject_Activated(sender, e);
                toolTip1.Show("Thêm thành công!", btnAddNew, 0, 0, 2000);
                txtClassSubjectID.Text = null;
                cbSubjectName.Text = null;
                cbFacultyName.Text = null;
                txtClassSubjectName.Text = null;
            }
            catch (Exception ex)
            {
                toolTip1.Show("Thêm thất bại! Error: " + ex.Message, btnAddNew, 0, 0, 2000);
            }

        }

        private void fManageClassSubject_Activated(object sender, EventArgs e)
        {
            fManageClassSubject_Load(sender, e);
        }

        private void cbFindFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFindSubject.DisplayMember = "SubjectName";
            cbFindSubject.ValueMember = "SubjectID";
            cbFindSubject.DataSource = db.Subjects.Where(o => o.FacultyID.Equals(cbFindFaculty.SelectedValue))
                .Select(p => new { p.SubjectID, p.SubjectName }).ToList();
            cbFindSubject.Text = null;
        }

        private void cbFindSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ClassSubjects.Where(c => c.SubjectID == Convert.ToInt64(cbFindSubject.SelectedValue)).Select(p => new
            {
                FacultyID = cbFindFaculty.SelectedValue,
                p.ClassSubjectID,
                ClassSubjectName = cbFindSubject.Text,
                p.ClassName,
                NumberOfStudents = p.Scores.Count()
            }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string className;
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                className = selectedRow.Cells["ClassName"].Value.ToString();
                long subjectID = Convert.ToInt64(cbFindSubject.SelectedValue);
                string classSubjectID = db.ClassSubjects.Single(c => c.ClassName.Equals(className)).ClassSubjectID;
                fEditClassSubject f = new fEditClassSubject(subjectID, classSubjectID);
                f.Show();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                if (selectedRow.Cells["NumberOfStudents"].Value.ToString().Equals("0"))
                {
                    className = selectedRow.Cells["ClassName"].Value.ToString();
                    if(MessageBox.Show("Bạn có chắc muốn xoá lớp " + className + " hay không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            string classSubjectID = selectedRow.Cells["ClassSubjectID"].Value.ToString();
                            ClassSubject classSubject = db.ClassSubjects.Single(c => c.ClassSubjectID.Equals(classSubjectID));
                            db.ClassSubjects.Remove(classSubject);
                            db.SaveChanges();
                            MessageBox.Show("Xoá thành công!", "Thành công", MessageBoxButtons.OK);
                            fManageClassSubject_Activated(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xoá thất bại! Error: " + ex.Message, "Thất bại", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xoá một lớp học phần đã có học viên", "Thất bại", MessageBoxButtons.OK);
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
