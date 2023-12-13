namespace ScoreManagement
{
    partial class fEditStudentInfo
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
            dtDateOfBirth = new DateTimePicker();
            label7 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            cbGender = new ComboBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtDateOfBirth.Location = new Point(190, 198);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(154, 27);
            dtDateOfBirth.TabIndex = 77;
            dtDateOfBirth.Validating += dtDateOfBirth_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(50, 127);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 74;
            label7.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 57);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 72;
            label2.Text = "Họ và tên";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(190, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 27);
            txtName.TabIndex = 71;
            txtName.Validating += txtName_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(50, 198);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 70;
            label6.Text = "Ngày sinh";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gray;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(50, 311);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 50);
            btnSave.TabIndex = 78;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(342, 311);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(206, 50);
            btnClose.TabIndex = 79;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(190, 128);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(132, 28);
            cbGender.TabIndex = 80;
            // 
            // fEditStudentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 436);
            Controls.Add(cbGender);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dtDateOfBirth);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label6);
            Name = "fEditStudentInfo";
            Text = "Cập nhật thông tin";
            FormClosing += fEditStudentInfo_FormClosing;
            Load += fEditStudentInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtDateOfBirth;
        private Label label7;
        private Label label2;
        private TextBox txtName;
        private Label label6;
        private Button btnSave;
        private Button btnClose;
        private ComboBox cbGender;
        private ToolTip toolTip1;
    }
}