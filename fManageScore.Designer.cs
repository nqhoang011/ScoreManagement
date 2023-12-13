namespace ScoreManagement
{
    partial class fManageScore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            btnRefresh = new Button();
            btClose = new Button();
            btNewScore = new Button();
            groupBox1 = new GroupBox();
            btFind = new Button();
            txtStudentID = new TextBox();
            button3 = new Button();
            label7 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            GroupClassID = new DataGridViewTextBoxColumn();
            SubjectID = new DataGridViewTextBoxColumn();
            MidtermScore = new DataGridViewTextBoxColumn();
            FinalScore = new DataGridViewTextBoxColumn();
            AverageScore = new DataGridViewTextBoxColumn();
            Failed = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            groupBox3 = new GroupBox();
            cbClassSubject = new ComboBox();
            label4 = new Label();
            cbFaculty = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbSubjectName = new ComboBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Image = Properties.Resources.win1;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1924, 116);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 116);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.AccessibleRole = AccessibleRole.IpAddress;
            panel3.BackColor = SystemColors.MenuBar;
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btClose);
            panel3.Controls.Add(btNewScore);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 939);
            panel3.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkSlateGray;
            btnRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(1592, 469);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(196, 71);
            btnRefresh.TabIndex = 47;
            btnRefresh.Text = "Làm mới bảng điểm";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(1592, 591);
            btClose.Name = "btClose";
            btClose.Size = new Size(196, 70);
            btClose.TabIndex = 42;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btNewScore
            // 
            btNewScore.BackColor = Color.DarkSlateGray;
            btNewScore.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btNewScore.ForeColor = SystemColors.ControlLightLight;
            btNewScore.Location = new Point(56, 31);
            btNewScore.Name = "btNewScore";
            btNewScore.Size = new Size(196, 71);
            btNewScore.TabIndex = 39;
            btNewScore.Text = "Nhập mới điểm";
            btNewScore.UseVisualStyleBackColor = false;
            btNewScore.Click += btNewScore_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btFind);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1465, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 197);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm ";
            // 
            // btFind
            // 
            btFind.BackColor = Color.Gray;
            btFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btFind.ForeColor = SystemColors.ButtonHighlight;
            btFind.Location = new Point(271, 120);
            btFind.Name = "btFind";
            btFind.Size = new Size(87, 43);
            btFind.TabIndex = 53;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = false;
            btFind.Click += btFind_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(172, 62);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(186, 31);
            txtStudentID.TabIndex = 41;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1164, 129);
            button3.Name = "button3";
            button3.Size = new Size(133, 56);
            button3.TabIndex = 40;
            button3.Text = "Tìm kiếm";
            button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 61);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 37;
            label7.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1418, 624);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, GroupClassID, SubjectID, MidtermScore, FinalScore, AverageScore, Failed, Edit, Delete });
            dataGridView1.Location = new Point(44, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1306, 520);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // GroupClassID
            // 
            GroupClassID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GroupClassID.DataPropertyName = "GroupClassID";
            GroupClassID.HeaderText = "Mã lớp";
            GroupClassID.MinimumWidth = 6;
            GroupClassID.Name = "GroupClassID";
            GroupClassID.Width = 97;
            // 
            // SubjectID
            // 
            SubjectID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubjectID.DataPropertyName = "SubjectID";
            SubjectID.HeaderText = "Mã môn học";
            SubjectID.MinimumWidth = 6;
            SubjectID.Name = "SubjectID";
            SubjectID.Width = 142;
            // 
            // MidtermScore
            // 
            MidtermScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MidtermScore.DataPropertyName = "MidtermScore";
            MidtermScore.HeaderText = "Điểm quá trình";
            MidtermScore.MinimumWidth = 6;
            MidtermScore.Name = "MidtermScore";
            MidtermScore.Width = 159;
            // 
            // FinalScore
            // 
            FinalScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FinalScore.DataPropertyName = "FinalScore";
            FinalScore.HeaderText = "Điểm thi";
            FinalScore.MinimumWidth = 6;
            FinalScore.Name = "FinalScore";
            FinalScore.Width = 108;
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
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 48;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Xoá";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Xoá";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 49;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbClassSubject);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cbFaculty);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cbSubjectName);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(331, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1005, 190);
            groupBox3.TabIndex = 46;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lựa chọn";
            // 
            // cbClassSubject
            // 
            cbClassSubject.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbClassSubject.FormattingEnabled = true;
            cbClassSubject.Location = new Point(619, 124);
            cbClassSubject.Name = "cbClassSubject";
            cbClassSubject.Size = new Size(280, 33);
            cbClassSubject.TabIndex = 38;
            cbClassSubject.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(464, 127);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 37;
            label4.Text = "Lớp học phần";
            // 
            // cbFaculty
            // 
            cbFaculty.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(132, 65);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(280, 33);
            cbFaculty.TabIndex = 32;
            cbFaculty.SelectedIndexChanged += cbFaculty_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 68);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 31;
            label2.Text = "Khoa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(502, 68);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 33;
            label3.Text = "Môn học";
            // 
            // cbSubjectName
            // 
            cbSubjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubjectName.FormattingEnabled = true;
            cbSubjectName.Location = new Point(619, 65);
            cbSubjectName.Name = "cbSubjectName";
            cbSubjectName.Size = new Size(280, 33);
            cbSubjectName.TabIndex = 36;
            cbSubjectName.SelectedIndexChanged += cbSubjectName_SelectedIndexChanged;
            // 
            // fManageScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fManageScore";
            Text = "Quản lý điểm sinh viên";
            WindowState = FormWindowState.Maximized;
            Activated += fManageScore_Activated;
            Load += fManageScore_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label label7;
        private ComboBox cbSubjectName;
        private Label label3;
        private ComboBox cbFaculty;
        private Label label2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button btClose;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtStudentID;
        private Button btNewScore;
        private GroupBox groupBox3;
        private Button btFind;
        private ComboBox cbClassSubject;
        private Label label4;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn GroupClassID;
        private DataGridViewTextBoxColumn SubjectID;
        private DataGridViewTextBoxColumn MidtermScore;
        private DataGridViewTextBoxColumn FinalScore;
        private DataGridViewTextBoxColumn AverageScore;
        private DataGridViewCheckBoxColumn Failed;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private ToolTip toolTip1;
        private Button btnRefresh;
    }
}