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
    public partial class fChangePassword : Form
    {
        EFDbContext db = new EFDbContext();
        Account account;
        string accountID;
        public fChangePassword(string accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            account = db.Accounts.Single(p => p.AccountID == accountID);
            if(string.IsNullOrWhiteSpace(txtID.Text))
            {
                toolTip1.Show("Chưa nhập tên đăng nhập!", txtID, 0, 0, 2000);
                txtID.Focus();
                return;
            }
            if (txtID.Text != accountID)
            {
                toolTip1.Show("Sai tên đăng nhập!", txtID, 0, 0, 2000);
                txtID.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                toolTip1.Show("Chưa nhập mật khẩu cũ!", txtOldPassword, 0, 0, 2000);
                txtOldPassword.Focus();
                return;
            }
            if(txtOldPassword.Text != account.Password)
            {
                toolTip1.Show("Sai mật khẩu cũ!", txtOldPassword, 0, 0, 2000);
                txtOldPassword.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                toolTip1.Show("Chưa nhập mật khẩu mới!", txtNewPassword, 0, 0, 2000);
                txtNewPassword.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                toolTip1.Show("Chưa xác nhận mật khẩu mới!", txtConfirmPassword, 0, 0, 2000);
                txtConfirmPassword.Focus();
                return;
            }
            if(txtOldPassword.Text.Equals(txtNewPassword.Text))
            {
                toolTip1.Show("Mật khẩu cũ không được trùng mật khẩu mới!", txtNewPassword, 0, 0, 2000);
                txtNewPassword.Focus();
                return;
            }
            if(!txtNewPassword.Text.Equals(txtConfirmPassword.Text)) {
                toolTip1.Show("Xác nhận mật khẩu khác với mật khẩu mới!", txtConfirmPassword, 0, 0, 2000);
                txtConfirmPassword.Focus();
                return;
            }
            try
            {
                account.Password = txtNewPassword.Text;
                db.SaveChanges();
                toolTip1.Show("Thay đổi mật khẩu thành công!", btSave, 0, 0, 2000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Thay đổi mật khẩu thất bại! Error: " + ex.Message, btSave, 0, 0, 2000);
            }
        }
    }
}
