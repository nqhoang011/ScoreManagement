namespace ScoreManagement
{
    partial class fListFailingSubject
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
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtStudentID = new TextBox();
            btnFind = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            GroupName = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            AverageScore = new DataGridViewTextBoxColumn();
            Failed = new DataGridViewCheckBoxColumn();
            btnClose = new Button();
            groupBox1 = new GroupBox();
            cbClassSubject = new ComboBox();
            label4 = new Label();
            cbFaculty = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbSubjectName = new ComboBox();
            btnCreateReport = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Size = new Size(1663, 108);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH SINH VIÊN TRƯỢT MÔN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtStudentID);
            groupBox2.Controls.Add(btnFind);
            groupBox2.Location = new Point(92, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(565, 138);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(24, 64);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 54;
            label7.Text = "Mã sinh viên";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(181, 61);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(186, 27);
            txtStudentID.TabIndex = 55;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Gray;
            btnFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFind.ForeColor = SystemColors.ButtonHighlight;
            btnFind.Location = new Point(427, 55);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(87, 43);
            btnFind.TabIndex = 56;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(92, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1045, 542);
            groupBox3.TabIndex = 60;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách trượt môn";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, GroupName, SubjectName, AverageScore, Failed });
            dataGridView1.Location = new Point(58, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(935, 445);
            dataGridView1.TabIndex = 0;
            // 
            // StudentID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "MSSV";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.Width = 88;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "Tên sinh viên";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.Width = 141;
            // 
            // GroupName
            // 
            GroupName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GroupName.DataPropertyName = "GroupName";
            GroupName.HeaderText = "Lớp";
            GroupName.MinimumWidth = 6;
            GroupName.Name = "GroupName";
            GroupName.Width = 71;
            // 
            // SubjectName
            // 
            SubjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "Môn học";
            SubjectName.MinimumWidth = 6;
            SubjectName.Name = "SubjectName";
            SubjectName.Width = 112;
            // 
            // AverageScore
            // 
            AverageScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AverageScore.DataPropertyName = "AverageScore";
            AverageScore.HeaderText = "Điểm trung bình";
            AverageScore.MinimumWidth = 6;
            AverageScore.Name = "AverageScore";
            AverageScore.Width = 171;
            // 
            // Failed
            // 
            Failed.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Failed.DataPropertyName = "Failed";
            Failed.HeaderText = "Không đạt";
            Failed.MinimumWidth = 6;
            Failed.Name = "Failed";
            Failed.Width = 101;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkSlateGray;
            btnClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(1255, 433);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(249, 71);
            btnClose.TabIndex = 48;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(cbClassSubject);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbFaculty);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbSubjectName);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(721, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(906, 138);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lựa chọn";
            // 
            // cbClassSubject
            // 
            cbClassSubject.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbClassSubject.FormattingEnabled = true;
            cbClassSubject.Location = new Point(591, 82);
            cbClassSubject.Name = "cbClassSubject";
            cbClassSubject.Size = new Size(280, 33);
            cbClassSubject.TabIndex = 44;
            cbClassSubject.SelectedIndexChanged += cbClassSubject_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(436, 85);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 43;
            label4.Text = "Lớp học phần";
            // 
            // cbFaculty
            // 
            cbFaculty.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(125, 52);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(280, 33);
            cbFaculty.TabIndex = 40;
            cbFaculty.SelectedIndexChanged += cbFaculty_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 55);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 39;
            label2.Text = "Khoa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(474, 26);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 41;
            label3.Text = "Môn học";
            // 
            // cbSubjectName
            // 
            cbSubjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubjectName.FormattingEnabled = true;
            cbSubjectName.Location = new Point(591, 23);
            cbSubjectName.Name = "cbSubjectName";
            cbSubjectName.Size = new Size(280, 33);
            cbSubjectName.TabIndex = 42;
            cbSubjectName.SelectedIndexChanged += cbSubjectName_SelectedIndexChanged;
            // 
            // btnCreateReport
            // 
            btnCreateReport.BackColor = Color.DarkSlateGray;
            btnCreateReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateReport.ForeColor = SystemColors.ControlLightLight;
            btnCreateReport.Location = new Point(1255, 320);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(249, 71);
            btnCreateReport.TabIndex = 62;
            btnCreateReport.Text = "Tạo báo cáo";
            btnCreateReport.UseVisualStyleBackColor = false;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // fListFailingSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1663, 1055);
            Controls.Add(btnCreateReport);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "fListFailingSubject";
            Text = "Danh sách sinh viên trượt môn";
            WindowState = FormWindowState.Maximized;
            Load += fListFailingSubject_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtStudentID;
        private Button btnFind;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn GroupName;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn AverageScore;
        private DataGridViewCheckBoxColumn Failed;
        private Button btnClose;
        private GroupBox groupBox1;
        private ComboBox cbClassSubject;
        private Label label4;
        private ComboBox cbFaculty;
        private Label label2;
        private Label label3;
        private ComboBox cbSubjectName;
        private Button btnCreateReport;
    }
}