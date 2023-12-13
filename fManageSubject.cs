using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
    public partial class fManageSubject : Form
    {
        EFDbContext db = new EFDbContext();
        public fManageSubject()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fManageSubject_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Subjects.Select(p => new
            {
                p.SubjectID,
                p.SubjectName,
                p.FacultyID,
                NumberOfClassSubjects = db.ClassSubjects.Where(c => c.SubjectID == p.SubjectID).Count()
            }).ToList();
            cbFaculty.DisplayMember = "FacultyName";
            cbFaculty.ValueMember = "FacultyID";
            cbFaculty.DataSource = db.Faculties.Select(p => new
            {
                p.FacultyName,
                p.FacultyID
            }).ToList();
            cbFaculty.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                toolTip1.Show("Chưa nhập tên môn học!", txtSubjectName, 0, 0, 2000);
                txtSubjectName.Focus();
                return;
            }
            if (db.Subjects.Select(o => o.SubjectName).ToList().Contains(txtSubjectName.Text))
            {
                toolTip1.Show("Tên môn học đã tồn tại!", txtSubjectName, 0, 0, 2000);
                txtSubjectName.Focus();
                return;
            }
            try
            {
                Subject subject = new Subject();
                subject.SubjectName = txtSubjectName.Text;
                subject.FacultyID = cbFaculty.SelectedValue.ToString();
                db.Subjects.Add(subject);
                db.SaveChanges();
                toolTip1.Show("Thêm môn học mới thành công!", btnAdd, 0, 0, 2000);
                txtSubjectName.Text = null;
                fManageSubject_Activated(sender, e);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lỗi, không thêm được! Error: " + ex.Message, btnAdd, 0, 0, 2000);
            }

        }

        private void fManageSubject_Activated(object sender, EventArgs e)
        {
            fManageSubject_Load(sender, e);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            if(e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                if(selectedRow.Cells["NumberOfClassSubjects"].Value.ToString().Equals("0"))
                {
                    string className = selectedRow.Cells["SubjectName"].Value.ToString();
                    if(MessageBox.Show("Bạn có chắc muốn xoá môn " + className + " hay không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string subjectID = selectedRow.Cells["subjectID"].Value.ToString();
                        try
                        {
                            Subject subject = db.Subjects.Single(c => c.SubjectID.Equals(subjectID));
                            db.Subjects.Remove(subject);
                            db.SaveChanges();
                            MessageBox.Show("Xoá thành công!", "Thành công", MessageBoxButtons.OK);
                            fManageSubject_Activated(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xoá thất bại! Error: " + ex.Message, "Thất bại", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xoá môn học đã có lớp học!", "Thất bại", MessageBoxButtons.OK);
                    return;
                }
            }
            if(e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                if (selectedRow.Cells["NumberOfClassSubjects"].Value.ToString().Equals("0"))
                {
                    string SubjectID = selectedRow.Cells["SubjectID"].Value.ToString();

                    if(!Utility.IsOpeningForm("fEditSubject1"))
                    {
                        fEditSubject1 f = new fEditSubject1(SubjectID);
                        f.Show();
                    }
                }
                else
                {
                    string SubjectID = selectedRow.Cells["SubjectID"].Value.ToString();
                    if (!Utility.IsOpeningForm("fEditSubject2"))
                    {
                        fEditSubject2 f = new fEditSubject2(SubjectID);
                        f.Show();
                    }
                }
            }
        }
    }
}
