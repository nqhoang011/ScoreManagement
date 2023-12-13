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
    public partial class fMainAdmin : Form
    {
        string AccountID;
        public fMainAdmin(string accountID)
        {
            InitializeComponent();
            this.AccountID = accountID;
        }

        private void quảnLýSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fManageStudent"))
            {
                fManageStudent f = new fManageStudent();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fManageScore"))
            {
                fManageScore f = new fManageScore();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quảnLýKhoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fManageFaculty"))
            {
                fManageFaculty f = new fManageFaculty();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void quảnLýLớpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fManageClass"))
            {
                fManageClass f = new fManageClass();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void quảnLýMônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fManageSubject"))
            {
                fManageSubject f = new fManageSubject();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword(AccountID);
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin f = new fLogin();
            //f.MdiParent = this;
            f.Show();
        }

        private void traCứuĐiểmNhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLookUpScore f = new fLookUpScore();
            f.MdiParent = this;
            f.Show();
        }

        private void dSSinhViênHọcLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fListFailingSubject"))
            {
                fListFailingSubject f = new fListFailingSubject();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void fMainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utility.IsOpeningForm("fManageClassSubject"))
            {
                fManageClassSubject f = new fManageClassSubject();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tạoBảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Utility.IsOpeningForm("fCreateTranscript"))
            {
                FCreateTranscript f = new FCreateTranscript();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
