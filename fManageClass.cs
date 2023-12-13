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
    public partial class fManageClass : Form
    {
        EFDbContext db = new EFDbContext();
        GroupClass groupClass;
        public fManageClass()
        {
            InitializeComponent();
        }

        private void fManageClass_Load(object sender, EventArgs e)
        {
            cbFacultyID.DisplayMember = "FacultyID";
            cbFacultyID.ValueMember = "FacultyID";
            cbFacultyID.DataSource = db.Faculties.Select(c => c.FacultyID).ToList();
            cbFacultyID.Text = null;
            dataGridView1.DataSource = db.GroupClasses.Select(p => new
            {
                p.FacultyID,
                ClassID = p.GroupClassID,
                ClassName = p.GroupName,
                NumberOfStudents = p.Accounts.Where(c => c.AccountID.Substring(0, 2).Equals("SV")).Count()
            }).ToList();
        }

        private void fManageClass_Activated(object sender, EventArgs e)
        {
            fManageClass_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbFacultyID.Text))
            {
                toolTip1.Show("Chưa chọn khoa!", cbFacultyID, 0, 0, 2000);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGroupID.Text))
            {
                toolTip1.Show("Chưa nhập mã lớp!", txtGroupID, 0, 0, 2000);
                return;
            }
            List<string> ID = db.GroupClasses.Where(c => c.FacultyID == cbFacultyID.Text).Select(o => o.GroupClassID).ToList();
            if (ID.Contains(txtGroupID.Text))
            {
                toolTip1.Show("Mã lớp đã tồn tại!", txtGroupID, 0, 0, 2000);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                toolTip1.Show("Chưa nhập tên lớp!", txtClassName, 0, 0, 2000);
            }
            List<string> gc = db.GroupClasses.Select(o => o.GroupName).ToList();
            if (gc.Contains(txtClassName.Text))
            {
                toolTip1.Show("Tên lớp đã tồn tại!", txtClassName, 0, 0, 2000);
            }
            try
            {
                groupClass = new GroupClass();
                groupClass.FacultyID = cbFacultyID.Text;
                groupClass.GroupClassID = txtGroupID.Text;
                groupClass.GroupName = txtClassName.Text;
                db.GroupClasses.Add(groupClass);
                db.SaveChanges();
                toolTip1.Show("Lưu thành công!", btnAddNew, 0, 0, 2000);
                txtGroupID.Text = null;
                txtClassName.Text = null;
                fManageClass_Activated(sender, e);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lỗi, không thể thêm lớp! Error: " + ex.Message, btnAddNew, 0, 0, 2000);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFindClass.Text))
            {
                fManageClass_Activated(sender, e);
            }
            dataGridView1.DataSource = db.GroupClasses.Select(p => new
            {
                p.FacultyID,
                ClassID = p.GroupClassID,
                ClassName = p.GroupName,
                NumberOfStudents = p.Accounts.Where(c => c.AccountID.Substring(0, 2).Equals("SV")).Count()
            }).Where(c => c.ClassName.Contains(txtFindClass.Text)).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            if(e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                string groupClassID = selectedRow.Cells["ClassID"].Value.ToString();
                string groupName = selectedRow.Cells["ClassName"].Value.ToString();
                if (selectedRow.Cells["NumberOfStudents"].Value.ToString().Equals("0"))
                {
                    if(MessageBox.Show("Bạn có chắc muốn xoá lớp " + groupName + " không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        GroupClass groupClass = db.GroupClasses.Single(c => c.GroupClassID.Equals(groupClassID));
                        db.GroupClasses.Remove(groupClass);
                        db.SaveChanges();
                        MessageBox.Show("Xoá thành công!", "Thành công", MessageBoxButtons.OK);
                        fManageClass_Activated(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xoá lớp đã có sinh viên!", "Thất bại", MessageBoxButtons.OK);
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                string groupClassID = selectedRow.Cells["ClassID"].Value.ToString();
                string groupName = selectedRow.Cells["ClassName"].Value.ToString();
                if (selectedRow.Cells["NumberOfStudents"].Value.ToString().Equals("0"))
                {
                    if(!Utility.IsOpeningForm("fEditGroupClass1"))
                    {
                        fEditGroupClass1 f = new fEditGroupClass1(groupClassID);
                        f.Show();
                    }
                    
                }
                else
                {
                    if(!Utility.IsOpeningForm("fEditGroupClass2"))
                    {
                        fEditGroupClass2 f = new fEditGroupClass2(groupClassID);
                        f.Show();
                    }
                }
            }
        }
    }
}
