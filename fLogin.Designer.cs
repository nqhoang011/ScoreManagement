namespace ScoreManagement
{
    partial class fLogin
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
            label1 = new Label();
            panel1 = new Panel();
            lblMessage = new Label();
            btLogin = new Button();
            btClose = new Button();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(693, 77);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.zyro_image;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblMessage);
            panel1.Controls.Add(btLogin);
            panel1.Controls.Add(btClose);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 558);
            panel1.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = SystemColors.HighlightText;
            lblMessage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(185, 270);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(109, 31);
            lblMessage.TabIndex = 45;
            lblMessage.Text = "Xin chào!";
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.DarkSlateGray;
            btLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.ForeColor = SystemColors.ControlLightLight;
            btLogin.Location = new Point(397, 475);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(135, 47);
            btLogin.TabIndex = 43;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(146, 475);
            btClose.Name = "btClose";
            btClose.Size = new Size(135, 47);
            btClose.TabIndex = 44;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(272, 400);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(335, 31);
            txtPassword.TabIndex = 9;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(272, 341);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(335, 31);
            txtUser.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(89, 400);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(89, 344);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 6;
            label2.Text = "Tên đăng nhập";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 635);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "fLogin";
            Text = "ĐĂNG NHẬP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Label label3;
        private Label label2;
        private Button btLogin;
        private Button btClose;
        private Label lblMessage;
    }
}