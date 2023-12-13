namespace ScoreManagement
{
    partial class fEditStudentInfoForTeacher
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
            cbGender = new ComboBox();
            btnClose = new Button();
            btnSave = new Button();
            dtDateOfBirth = new DateTimePicker();
            label7 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            label1 = new Label();
            txtStudentID = new TextBox();
            cbFaculty = new ComboBox();
            label3 = new Label();
            cbClass = new ComboBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(137, 114);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(142, 28);
            cbGender.TabIndex = 88;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(633, 325);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(206, 50);
            btnClose.TabIndex = 87;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gray;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(341, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 50);
            btnSave.TabIndex = 86;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtDateOfBirth.Location = new Point(607, 190);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(154, 27);
            dtDateOfBirth.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 113);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 84;
            label7.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 43);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 83;
            label2.Text = "Họ và tên";
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 27);
            txtName.TabIndex = 82;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(497, 190);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 81;
            label6.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(529, 44);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 89;
            label1.Text = "MSSV";
            // 
            // txtStudentID
            // 
            txtStudentID.Enabled = false;
            txtStudentID.Location = new Point(607, 41);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(232, 27);
            txtStudentID.TabIndex = 90;
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbFaculty.Location = new Point(529, 110);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(310, 28);
            cbFaculty.TabIndex = 92;
            cbFaculty.SelectedIndexChanged += cbFaculty_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(442, 113);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 91;
            label3.Text = "Khoa";
            // 
            // cbClass
            // 
            cbClass.FormattingEnabled = true;
            cbClass.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbClass.Location = new Point(137, 187);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(170, 28);
            cbClass.TabIndex = 94;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(69, 190);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 93;
            label4.Text = "Lớp";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(137, 254);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 27);
            txtPassword.TabIndex = 96;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 256);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 95;
            label5.Text = "Mật khẩu";
            // 
            // fEditStudentInfoForTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 450);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(cbClass);
            Controls.Add(label4);
            Controls.Add(cbFaculty);
            Controls.Add(label3);
            Controls.Add(txtStudentID);
            Controls.Add(label1);
            Controls.Add(cbGender);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dtDateOfBirth);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label6);
            Name = "fEditStudentInfoForTeacher";
            Text = "Cập nhật thông tin sinh viên";
            Load += fEditStudentInfoForTeacher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGender;
        private Button btnClose;
        private Button btnSave;
        private DateTimePicker dtDateOfBirth;
        private Label label7;
        private Label label2;
        private TextBox txtName;
        private Label label6;
        private Label label1;
        private TextBox txtStudentID;
        private ComboBox cbFaculty;
        private Label label3;
        private ComboBox cbClass;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private ToolTip toolTip1;
    }
}