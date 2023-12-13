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
    public partial class fManageFaculty : Form
    {
        EFDbContext db = new EFDbContext();
        GroupClass groupClass;
        public fManageFaculty()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void fManageFaculty_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Faculties.Select(o => new
            {
                o.FacultyID,
                o.FacultyName,
                NumberOfClasses = o.GroupClasses.Where(c => c.FacultyID == o.FacultyID).Count(),
                NumberOfStudents = o.GroupClasses.Where(c => c.FacultyID == o.FacultyID).SelectMany(c2 => c2.Accounts).Where(c3 => c3.AccountID.Substring(0, 2) == "SV").Count()
            }).ToList();
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFacultyname.Text))
            {
                toolTip1.Show("Tên khoa không được để trống!", txtFacultyname, 0, 0, 2000);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFacultyID.Text))
            {
                toolTip1.Show("Mã khoa không được để trống!", txtFacultyID, 0, 0, 2000);
                return;
            }
            List<string> ID = db.Faculties.Select(p => p.FacultyID).ToList();
            if (ID.Contains(txtFacultyID.Text))
            {
                toolTip1.Show("Mã khoa đã tồn tại!", txtFacultyID, 0, 0, 2000);
                return;
            }
            List<string> Name = db.Faculties.Select(p => p.FacultyName).ToList();
            if (Name.Contains(txtFacultyname.Text))
            {
                toolTip1.Show("Tên khoa đã tồn tại!", txtFacultyname, 0, 0, 1000);
            }
            Faculty nw = new Faculty();
            nw.FacultyID = txtFacultyID.Text;
            nw.FacultyName = txtFacultyname.Text;
            try
            {
                db.Faculties.Add(nw);
                db.SaveChanges();
                toolTip1.Show("Thêm khoa mới thành công!", btnAddFaculty, 0, 0, 2000);
                txtFacultyID.Text = null;
                txtFacultyname.Text = null;
                fManageFaculty_Load(sender, e);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Thêm khoa mới thất bại! Error: " + ex.Message, btnAddFaculty, 0, 0, 2000);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFindFaculty.Text == null)
            {
                fManageFaculty_Load(sender, e);
            }
            else
            {
                dataGridView1.DataSource = db.Faculties.Where(o => o.FacultyName.Contains(txtFindFaculty.Text)).Select(o => new
                {
                    o.FacultyID,
                    o.FacultyName,
                    NumberOfClasses = o.GroupClasses.Where(c => c.FacultyID == o.FacultyID).Count(),
                    NumberOfStudents = o.GroupClasses.Where(c => c.FacultyID == o.FacultyID).SelectMany(c2 => c2.Accounts).Where(c3 => c3.AccountID.Substring(0, 2) == "SV").Count(),
                }).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    string FacultyID = dataGridView1.Rows[e.RowIndex].Cells["FacultyID"].Value.ToString();
                    Faculty faculty = db.Faculties.Single(c => c.FacultyID == FacultyID);
                    if (MessageBox.Show("Bạn muốn xoá khoa " + faculty.FacultyName, "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.Faculties.Remove(faculty);
                        db.SaveChanges();
                        fManageFaculty_Activated(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, không xoá được! Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                string FacultyID = dataGridView1.Rows[e.RowIndex].Cells["FacultyID"].Value.ToString();
                if (!Utility.IsOpeningForm("fEditFalcuty"))
                {
                    fEditFaculty f = new fEditFaculty(FacultyID);
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }
        }

        private void fManageFaculty_Activated(object sender, EventArgs e)
        {
            fManageFaculty_Load(sender, e);
        }
    }
}
