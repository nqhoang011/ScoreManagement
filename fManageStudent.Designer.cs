namespace ScoreManagement
{
    partial class fManageStudent
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
            groupBox1 = new GroupBox();
            btnFind = new Button();
            txtStudentIDFind = new TextBox();
            label10 = new Label();
            cbFacultyFind = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            cbClassFind = new ComboBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            cbFaculty = new ComboBox();
            label11 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            dtDateOfBirth = new DateTimePicker();
            cbClassID = new ComboBox();
            label8 = new Label();
            btnAdd = new Button();
            label7 = new Label();
            cbGender = new ComboBox();
            label6 = new Label();
            txtStudentID = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            btClose = new Button();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            FacultyName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Size = new Size(1924, 103);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(495, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 295);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(txtStudentIDFind);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbFacultyFind);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbClassFind);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(140, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1209, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Gray;
            btnFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFind.ForeColor = SystemColors.ButtonHighlight;
            btnFind.Location = new Point(1033, 107);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(133, 56);
            btnFind.TabIndex = 51;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtStudentIDFind
            // 
            txtStudentIDFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentIDFind.Location = new Point(814, 106);
            txtStudentIDFind.Name = "txtStudentIDFind";
            txtStudentIDFind.Size = new Size(168, 31);
            txtStudentIDFind.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(664, 109);
            label10.Name = "label10";
            label10.Size = new Size(116, 25);
            label10.TabIndex = 49;
            label10.Text = "Mã sinh viên ";
            // 
            // cbFacultyFind
            // 
            cbFacultyFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFacultyFind.FormattingEnabled = true;
            cbFacultyFind.Location = new Point(176, 44);
            cbFacultyFind.Name = "cbFacultyFind";
            cbFacultyFind.Size = new Size(349, 33);
            cbFacultyFind.TabIndex = 45;
            cbFacultyFind.SelectedIndexChanged += cbFacultyFind_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 47);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 44;
            label2.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(666, 47);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 46;
            label4.Text = "Lớp";
            // 
            // cbClassFind
            // 
            cbClassFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbClassFind.FormattingEnabled = true;
            cbClassFind.Location = new Point(814, 44);
            cbClassFind.Name = "cbClassFind";
            cbClassFind.Size = new Size(170, 33);
            cbClassFind.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(btClose);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 805);
            panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(cbFaculty);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtDateOfBirth);
            groupBox2.Controls.Add(cbClassID);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbGender);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtStudentID);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(57, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 663);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thêm mới sinh viên";
            // 
            // cbFaculty
            // 
            cbFaculty.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(38, 359);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(309, 33);
            cbFaculty.TabIndex = 59;
            cbFaculty.SelectedIndexChanged += cbFaculty_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(38, 315);
            label11.Name = "label11";
            label11.Size = new Size(52, 25);
            label11.TabIndex = 58;
            label11.Text = "Khoa";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 485);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 31);
            txtPassword.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(38, 485);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 56;
            label9.Text = "Mật khẩu";
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtDateOfBirth.Location = new Point(158, 191);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(189, 31);
            dtDateOfBirth.TabIndex = 55;
            // 
            // cbClassID
            // 
            cbClassID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbClassID.FormattingEnabled = true;
            cbClassID.Location = new Point(160, 421);
            cbClassID.Name = "cbClassID";
            cbClassID.Size = new Size(187, 33);
            cbClassID.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(40, 424);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 53;
            label8.Text = "Mã lớp";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gray;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(121, 574);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 50);
            btnAdd.TabIndex = 52;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 257);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 52;
            label7.Text = "Giới tính";
            // 
            // cbGender
            // 
            cbGender.FlatStyle = FlatStyle.Popup;
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(158, 254);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(189, 33);
            cbGender.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 191);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 50;
            label6.Text = "Ngày sinh";
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentID.Location = new Point(160, 46);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(187, 31);
            txtStudentID.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 49);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 47;
            label5.Text = "Mã sinh viên ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(38, 132);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 31);
            txtName.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 95);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 45;
            label3.Text = "Họ và tên";
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(334, 725);
            btClose.Name = "btClose";
            btClose.Size = new Size(110, 47);
            btClose.TabIndex = 44;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(495, 422);
            panel3.Name = "panel3";
            panel3.Size = new Size(1429, 486);
            panel3.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(54, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1295, 473);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sinh viên";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Birthday, Gender, ClassName, FacultyName, Password, Edit, Delete });
            dataGridView1.Location = new Point(39, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1222, 383);
            dataGridView1.TabIndex = 0;
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
            StudentName.HeaderText = "Họ và tên";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.Width = 118;
            // 
            // Birthday
            // 
            Birthday.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Birthday.DataPropertyName = "Birthday";
            Birthday.HeaderText = "Ngày sinh";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            Birthday.Width = 120;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // ClassName
            // 
            ClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClassName.DataPropertyName = "ClassName";
            ClassName.HeaderText = "Lớp";
            ClassName.MinimumWidth = 6;
            ClassName.Name = "ClassName";
            ClassName.Width = 71;
            // 
            // FacultyName
            // 
            FacultyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FacultyName.DataPropertyName = "FacultyName";
            FacultyName.HeaderText = "Khoa";
            FacultyName.MinimumWidth = 6;
            FacultyName.Name = "FacultyName";
            FacultyName.Width = 81;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Mật khẩu";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 125;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            // fManageStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1924, 908);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "fManageStudent";
            Text = "Quản lý sinh viên";
            WindowState = FormWindowState.Maximized;
            Activated += fManageStudent_Activated;
            Load += fManageStudent_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox cbFacultyFind;
        private Label label2;
        private Label label4;
        private ComboBox cbClassFind;
        private Panel panel2;
        private GroupBox groupBox2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private TextBox txtStudentID;
        private Label label5;
        private TextBox txtName;
        private Label label3;
        private Label label7;
        private ComboBox cbGender;
        private Label label6;
        private Button btClose;
        private TextBox txtStudentIDFind;
        private Label label10;
        private Button btnFind;
        private Button btnAdd;
        private ComboBox cbClassID;
        private Label label8;
        private DateTimePicker dtDateOfBirth;
        private Label label9;
        private TextBox txtPassword;
        private ComboBox cbFaculty;
        private Label label11;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn FacultyName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private ToolTip toolTip1;
    }
}