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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập tên người dùng?";
                txtUser.Select();
            }
            else if (txtPassword.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu?";
                txtPassword.Select();
            }
            else
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        Utility.account = db.Accounts.SingleOrDefault(e => e.AccountID == txtUser.Text && e.Password == txtPassword.Text);
                        if (Utility.account != null) //Nếu đăng nhập thành công
                        {
                            DialogResult = DialogResult.OK; //đóng form
                            if (Utility.account.AccountID.Substring(0, 2) == "SV")
                            {
                                this.Hide();
                                fMainStudent f = new fMainStudent(Utility.account.AccountID);
                                f.Show();
                            }
                            else
                            {
                                this.Hide();
                                fMainAdmin f = new fMainAdmin(Utility.account.AccountID);
                                f.Show();
                            }
                        }
                        else
                            lblMessage.Text = "Sai tên người dùng hoặc mật khẩu";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Lỗi! Error: " + ex.Message;
                }
            }
        }
    }
}
