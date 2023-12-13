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
    public partial class fManageStudent : Form
    {
        EFDbContext db = new EFDbContext();
        public fManageStudent()
        {
            InitializeComponent();
        }

        private void fManageStudent_Activated(object sender, EventArgs e)
        {
            fManageStudent_Load(sender, e);
        }

        private void fManageStudent_Load(object sender, EventArgs e)
        {
            dtDateOfBirth.Text = null;
            List<string> gender = new List<string>();
            gender.Add("Nam");
            gender.Add("Nữ");
            gender.Add("Khác");
            cbGender.DataSource = gender;
            cbGender.Text = null;
            cbFaculty.DisplayMember = "FacultyName";
            cbFaculty.ValueMember = "FacultyID";
            cbFaculty.DataSource = db.Faculties.Select(c => new
            {
                c.FacultyName,
                c.FacultyID
            }).ToList();
            cbFaculty.Text = null;
            cbClassID.Text = null;
            dataGridView1.DataSource = db.Accounts.OrderBy(c => c.GroupClassID).Where(c => c.AccountID.Substring(0, 2).Equals("SV")).Select(p => new
            {
                StudentID = p.AccountID,
                StudentName = p.Name,
                Birthday = p.DateOfBirth.Date.ToString(),
                Gender = (p.Gender == true ? "Nam" : (p.Gender == false ? "Nữ" : "Khác")),
                ClassName = p.GroupClass.GroupName,
                FacultyName = p.GroupClass.Faculty.FacultyName,
                Password = p.Password
            }).ToList();
            cbFacultyFind.DisplayMember = "FacultyName";
            cbFacultyFind.ValueMember = "FacultyID";
            cbFacultyFind.DataSource = db.Faculties.Select(c => new
            {
                c.FacultyName,
                c.FacultyID
            }).ToList();
            cbFacultyFind.Text = null;
        }

        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFaculty.SelectedItem == null)
            {
                cbClassID.DataSource = db.GroupClasses.Select(c => c.GroupClassID).ToList();
            }
            else
            {
                string selectedValue = cbFaculty.SelectedValue.ToString();
                cbClassID.DataSource = db.GroupClasses.Where(c => c.FacultyID.Equals(selectedValue)).Select(o => o.GroupClassID).ToList();
            }
            cbClassID.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                toolTip1.Show("Mã số sinh viên không được để trống!", txtStudentID, 0, 0, 2000);
                txtStudentID.Focus();
                return;
            }
            if (!txtStudentID.Text.Substring(0, 2).Equals("SV"))
            {
                toolTip1.Show("Mã số sinh viên không hợp lệ, phải bắt đầu bằng 'SV'", txtStudentID, 0, 0, 2000);
                txtStudentID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Tên sinh viên không được để trống!", txtName, 0, 0, 2000);
                txtName.Focus();
                return;
            }
            if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên sinh viên không được dài quá 100 ký tự.", txtName, 0, 0, 2000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(dtDateOfBirth.Text))
            {
                toolTip1.Show("Chưa chọn ngày sinh cho sinh viên!", dtDateOfBirth, 0, 0, 2000);
                dtDateOfBirth.Focus();
                return;
            }
            if (dtDateOfBirth.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại!", dtDateOfBirth, 0, 0, 2000);
                dtDateOfBirth.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbGender.Text))
            {
                toolTip1.Show("Chưa chọn giới tính!", cbGender, 0, 0, 2000);
                cbGender.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbFaculty.Text))
            {
                toolTip1.Show("Chưa chọn khoa!", cbFaculty, 0, 0, 2000);
                cbFaculty.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbClassID.Text))
            {
                toolTip1.Show("Chưa chọn lớp!", cbClassID, 0, 0, 2000);
                cbClassID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                toolTip1.Show("Chưa nhập mật khẩu!", txtPassword, 0, 0, 2000);
                txtPassword.Focus();
                return;
            }
            try
            {
                Account account = new Account();
                account.AccountID = txtStudentID.Text;
                account.Password = txtPassword.Text;
                account.Name = txtName.Text;
                account.Gender = (cbGender.Text.Equals("Nam") ? true : (cbGender.Text.Equals("Nữ") ? false : null));
                account.DateOfBirth = dtDateOfBirth.Value.Date;
                account.GroupClassID = cbClassID.Text;
                db.Accounts.Add(account);
                db.SaveChanges();
                toolTip1.Show("Thêm mới thành công!", btnAdd, 0, 0, 2000);
                txtStudentID.Text = null;
                txtPassword.Text = null;
                txtName.Text = null;
                cbGender.Text = null;
                dtDateOfBirth.Text = null;
                cbClassID.Text = null;
                fManageStudent_Activated(sender, e);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Thêm mới thất bại! Error: " + ex.Message, btnAdd, 0, 0, 2000);
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string AccountID = dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (!Utility.IsOpeningForm("fEditStudentInfoForTeacher"))
                {
                    fEditStudentInfoForTeacher f = new fEditStudentInfoForTeacher(AccountID);
                    f.MdiParent = this.MdiParent;
                    f.Show();
                    fManageStudent_Activated(sender, e);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                Account account = db.Accounts.Single(c => c.AccountID == AccountID);
                if(MessageBox.Show("Bạn muốn xoá sinh viên " + account.Name + "?", "Xoá sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.Accounts.Remove(account);
                        db.SaveChanges();
                        fManageStudent_Activated(sender, e);
                        MessageBox.Show("Xoá thành công!", "Thành công", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xoá thất bại! Error: " + ex.Message, "Thất bại", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void cbFacultyFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFacultyFind.SelectedItem == null)
            {
                cbClassFind.DataSource = db.GroupClasses.Select(c => c.GroupName).ToList();
            }
            else
            {
                cbClassFind.DisplayMember = "GroupName";
                cbClassFind.ValueMember = "GroupClassID";
                cbClassFind.DataSource = db.GroupClasses.Where(c => c.Faculty.FacultyName.Equals(cbFacultyFind.Text)).Select(o => o.GroupName).ToList();
            }
            cbClassFind.Text = null;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbFacultyFind.SelectedItem != null)
            {
                if (cbClassFind.SelectedItem != null)
                {
                    if (!string.IsNullOrWhiteSpace(txtStudentIDFind.Text))
                    {
                        dataGridView1.DataSource = db.Accounts.OrderBy(c => c.GroupClassID).Where(c => c.AccountID.Substring(0, 2).Equals("SV") && c.AccountID.Contains(txtStudentIDFind.Text) && c.GroupClass.GroupName.Equals(cbClassFind.Text)).Select(p => new
                        {
                            StudentID = p.AccountID,
                            StudentName = p.Name,
                            Birthday = p.DateOfBirth.Date.ToString(),
                            Gender = (p.Gender == true ? "Nam" : (p.Gender == false ? "Nữ" : "Khác")),
                            ClassName = p.GroupClass.GroupName,
                            FacultyName = p.GroupClass.Faculty.FacultyName,
                            Password = p.Password
                        }).ToList();
                    }
                    else
                    {
                        dataGridView1.DataSource = db.Accounts.OrderBy(c => c.GroupClassID).Where(c => c.AccountID.Substring(0, 2).Equals("SV") && c.AccountID.Contains(txtStudentIDFind.Text) && c.GroupClass.GroupName.Equals(cbClassFind.Text)).Select(p => new
                        {
                            StudentID = p.AccountID,
                            StudentName = p.Name,
                            Birthday = p.DateOfBirth.Date.ToString(),
                            Gender = (p.Gender == true ? "Nam" : (p.Gender == false ? "Nữ" : "Khác")),
                            ClassName = p.GroupClass.GroupName,
                            FacultyName = p.GroupClass.Faculty.FacultyName,
                            Password = p.Password
                        }).ToList();
                    }
                }
                else
                {
                    toolTip1.Show("Chưa chọn lớp!", cbClassFind, 0, 0, 2000);
                    cbClassFind.Focus();
                    return;
                }
            }
            else
            {
                toolTip1.Show("Chưa chọn khoa!", cbFacultyFind, 0, 0, 2000);
                cbFacultyFind.Focus();
                return;
            }
        }
    }
}
