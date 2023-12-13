using Microsoft.Identity.Client;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ScoreManagement
{
    public partial class fEditStudentInfo : Form
    {
        Account account;
        EFDbContext db = new EFDbContext();
        string AccountID;
        public fEditStudentInfo(string accountID)
        {
            InitializeComponent();
            this.AccountID = accountID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên của bạn!", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (dtDateOfBirth.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dtDateOfBirth, 0, 0, 1000);
                return;
            }
            try
            {
                account.Name = txtName.Text;
                account.Gender = (cbGender.Text == "Nam" ? true : (cbGender.Text == "Nữ" ? false : null));
                account.DateOfBirth = dtDateOfBirth.Value.Date;
                db.SaveChanges();
                toolTip1.Show("Lưu thành công!", btnSave, 0, 0, 1000);
                btnClose.Focus();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
            }
        }

        private void fEditStudentInfo_Load(object sender, EventArgs e)
        {
            account = db.Accounts.Single(p => p.AccountID == AccountID);
            txtName.Text = account.Name;
            List<string> gender = new List<string>();
            gender.Add("Nam");
            gender.Add("Nữ");
            gender.Add("Khác");
            cbGender.DataSource = gender;
            cbGender.Text = (account.Gender == true ? "Nam" : account.Gender == false ? "Nữ" : "Khác");
            dtDateOfBirth.Text = account.DateOfBirth.ToString();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên của bạn!", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên của bạn không được dài quá 100 ký tự.", txtName, 0, 0, 1000);
            }
        }

        private void dtDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (dtDateOfBirth.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dtDateOfBirth, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fEditStudentInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
