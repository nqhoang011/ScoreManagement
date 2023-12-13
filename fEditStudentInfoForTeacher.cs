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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScoreManagement
{
    public partial class fEditStudentInfoForTeacher : Form
    {
        EFDbContext db = new EFDbContext();
        string AccountID;
        Account account;
        public fEditStudentInfoForTeacher(string accountID)
        {
            InitializeComponent();
            this.AccountID = accountID;
        }

        private void fEditStudentInfoForTeacher_Load(object sender, EventArgs e)
        {
            account = db.Accounts.Single(c => c.AccountID == AccountID);
            txtName.Text = account.Name;
            txtStudentID.Text = account.AccountID;
            List<string> gender = new List<string>();
            gender.Add("Nam");
            gender.Add("Nữ");
            gender.Add("Khác");
            cbGender.DataSource = gender;
            cbGender.Text = (account.Gender == true ? "Nam" : account.Gender == false ? "Nữ" : "Khác");
            cbFaculty.DataSource = db.Faculties.Select(o => o.FacultyName).ToList();
            cbFaculty.Text = db.Faculties.Single(c => c.FacultyID.Equals(db.GroupClasses.Single(c2 => c2.Accounts.Single(c3 => c3.AccountID == AccountID).AccountID.Equals(AccountID)).FacultyID)).FacultyName;
            //string selectedValue = cbFaculty.SelectedValue.ToString();
            //cbClass.DataSource = db.GroupClasses.Where(c => c.FacultyID.Equals(selectedValue)).Select(o => o.GroupName).ToList();
            cbClass.DisplayMember = "GroupName";
            cbClass.ValueMember = "GroupClassID";
            cbClass.DataSource = db.GroupClasses.Where(c => c.Faculty.FacultyName.Equals(cbFaculty.Text)).Select(c => new
            {
                c.GroupClassID,
                c.GroupName
            }).ToList();
            cbClass.Text = db.GroupClasses.Single(c => c.Accounts.Single(c2 => c2.AccountID == AccountID).AccountID.Equals(AccountID)).GroupName;
            dtDateOfBirth.Text = account.DateOfBirth.ToString();
            txtPassword.Text = account.Password;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClass.DisplayMember = "GroupName";
            cbClass.ValueMember = "GroupClassID";
            cbClass.DataSource = db.GroupClasses.Where(c => c.Faculty.FacultyName.Equals(cbFaculty.Text)).Select(c => new
            {
                c.GroupClassID,
                c.GroupName
            }).ToList();
            cbClass.Text = null;
            //string selectedValue = cbFaculty.SelectedValue.ToString();
            //cbClass.DataSource = db.GroupClasses.Where(c => c.Equals(selectedValue)).Select(o => o.GroupName).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(cbClass.Text))
            {
                toolTip1.Show("Chưa chọn lớp!", cbClass, 0, 0, 2000);
                cbClass.Focus();
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
                //Account account = new Account();
                account = db.Accounts.Single(c => c.AccountID == this.AccountID);
                account.AccountID = txtStudentID.Text;
                account.Password = txtPassword.Text;
                account.Name = txtName.Text;
                account.Gender = (cbGender.Text.Equals("Nam") ? true : (cbGender.Text.Equals("Nữ") ? false : null));
                account.DateOfBirth = dtDateOfBirth.Value.Date;
                account.GroupClassID = db.GroupClasses.Single(c => c.GroupName == cbClass.Text).GroupClassID;
                db.SaveChanges();
                toolTip1.Show("Lưu thành công!", btnSave, 0, 0, 2000);
                txtStudentID.Text = null;
                txtPassword.Text = null;
                txtName.Text = null;
                cbGender.Text = null;
                dtDateOfBirth.Text = null;
                cbClass.Text = null;
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại! Error: " + ex.Message, btnSave, 0, 0, 2000);
            }
        }
    }
}
