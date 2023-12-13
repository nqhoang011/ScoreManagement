namespace ScoreManagement
{
    partial class fNewManageScore
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
            cbSubjectName = new ComboBox();
            cbClassName = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtMidtermScore = new TextBox();
            txtFinalScore = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            btSave = new Button();
            btClose = new Button();
            groupBox1 = new GroupBox();
            txtStudentID = new TextBox();
            cbFaculty = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            txtStudentName = new TextBox();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbSubjectName
            // 
            cbSubjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubjectName.FormattingEnabled = true;
            cbSubjectName.Location = new Point(134, 112);
            cbSubjectName.Name = "cbSubjectName";
            cbSubjectName.Size = new Size(349, 33);
            cbSubjectName.TabIndex = 46;
            cbSubjectName.SelectedIndexChanged += cbSubjectName_SelectedIndexChanged;
            // 
            // cbClassName
            // 
            cbClassName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbClassName.FormattingEnabled = true;
            cbClassName.Location = new Point(261, 173);
            cbClassName.Name = "cbClassName";
            cbClassName.Size = new Size(222, 33);
            cbClassName.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 176);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 42;
            label4.Text = "Lớp học phần";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 115);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 41;
            label3.Text = "Môn học";
            // 
            // txtMidtermScore
            // 
            txtMidtermScore.Location = new Point(31, 399);
            txtMidtermScore.Name = "txtMidtermScore";
            txtMidtermScore.Size = new Size(120, 31);
            txtMidtermScore.TabIndex = 47;
            // 
            // txtFinalScore
            // 
            txtFinalScore.Location = new Point(233, 399);
            txtFinalScore.Name = "txtFinalScore";
            txtFinalScore.Size = new Size(120, 31);
            txtFinalScore.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(233, 237);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 50;
            label1.Text = "Họ và tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 359);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 51;
            label5.Text = "Điểm quá trình";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(233, 359);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 52;
            label6.Text = "Điểm thi";
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkSlateGray;
            btSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = SystemColors.ControlLightLight;
            btSave.Location = new Point(637, 382);
            btSave.Name = "btSave";
            btSave.Size = new Size(110, 47);
            btSave.TabIndex = 53;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(637, 474);
            btClose.Name = "btClose";
            btClose.Size = new Size(110, 47);
            btClose.TabIndex = 54;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(cbFaculty);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtStudentName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbClassName);
            groupBox1.Controls.Add(txtMidtermScore);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFinalScore);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbSubjectName);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(58, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 479);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm mới";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(31, 279);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(163, 31);
            txtStudentID.TabIndex = 55;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // cbFaculty
            // 
            cbFaculty.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(134, 43);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(349, 33);
            cbFaculty.TabIndex = 40;
            cbFaculty.SelectedIndexChanged += cbFaculty_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(31, 237);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 54;
            label8.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 51);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 39;
            label2.Text = "Khoa";
            // 
            // txtStudentName
            // 
            txtStudentName.Enabled = false;
            txtStudentName.Location = new Point(233, 279);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(279, 31);
            txtStudentName.TabIndex = 53;
            // 
            // fNewManageScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 589);
            ControlBox = false;
            Controls.Add(btSave);
            Controls.Add(btClose);
            Controls.Add(groupBox1);
            Name = "fNewManageScore";
            Text = "Thêm điểm mới";
            Activated += fNewManageScore_Activated;
            Load += fNewManageScore_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbSubjectName;
        private ComboBox cbClassName;
        private Label label4;
        private Label label3;
        private TextBox txtMidtermScore;
        private TextBox txtFinalScore;
        private Label label1;
        private Label label5;
        private Label label6;
        private Button btSave;
        private Button btClose;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtStudentName;
        private ComboBox cbFaculty;
        private Label label2;
        private TextBox txtStudentID;
        private ToolTip toolTip1;
    }
}