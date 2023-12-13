namespace ScoreManagement
{
    partial class fChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            btSave = new Button();
            btClose = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtConfirmPassword = new TextBox();
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Image = Properties.Resources.win1;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(974, 71);
            label1.TabIndex = 1;
            label1.Text = "ĐỔI MẬT KHẨU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(btClose);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 614);
            panel1.TabIndex = 2;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkSlateGray;
            btSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = SystemColors.ControlLightLight;
            btSave.Location = new Point(583, 491);
            btSave.Name = "btSave";
            btSave.Size = new Size(110, 47);
            btSave.TabIndex = 43;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(791, 491);
            btClose.Name = "btClose";
            btClose.Size = new Size(110, 47);
            btClose.TabIndex = 44;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtOldPassword);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(82, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(819, 353);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 188);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 7;
            label5.Text = "Mật khẩu mới";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(363, 252);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(335, 31);
            txtConfirmPassword.TabIndex = 6;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(363, 121);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(335, 31);
            txtOldPassword.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(363, 185);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(335, 31);
            txtNewPassword.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(363, 62);
            txtID.Name = "txtID";
            txtID.Size = new Size(335, 31);
            txtID.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 252);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 2;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 127);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 68);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // fChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 685);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "fChangePassword";
            Text = "Quản lý tài khoản ";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtConfirmPassword;
        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtID;
        private Button btSave;
        private Button btClose;
        private ToolTip toolTip1;
    }
}