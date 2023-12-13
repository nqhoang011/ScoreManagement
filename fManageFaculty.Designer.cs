namespace ScoreManagement
{
    partial class fManageFaculty
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
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btClose = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtFacultyID = new TextBox();
            btnAddFaculty = new Button();
            label2 = new Label();
            txtFacultyname = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            btnFind = new Button();
            label4 = new Label();
            txtFindFaculty = new TextBox();
            toolTip1 = new ToolTip(components);
            FacultyID = new DataGridViewTextBoxColumn();
            FacultyName = new DataGridViewTextBoxColumn();
            NumberOfClasses = new DataGridViewTextBoxColumn();
            NumberOfStudents = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 112);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Image = Properties.Resources.win1;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1924, 112);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHOA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btClose);
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(0, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(709, 937);
            panel3.TabIndex = 6;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(440, 542);
            btClose.Name = "btClose";
            btClose.Size = new Size(128, 59);
            btClose.TabIndex = 50;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFacultyID);
            groupBox1.Controls.Add(btnAddFaculty);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFacultyname);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(107, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 399);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm mới khoa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(75, 221);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 49;
            label3.Text = "Mã khoa";
            // 
            // txtFacultyID
            // 
            txtFacultyID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFacultyID.Location = new Point(195, 215);
            txtFacultyID.Name = "txtFacultyID";
            txtFacultyID.Size = new Size(196, 31);
            txtFacultyID.TabIndex = 50;
            // 
            // btnAddFaculty
            // 
            btnAddFaculty.BackColor = Color.Gray;
            btnAddFaculty.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFaculty.ForeColor = SystemColors.ButtonHighlight;
            btnAddFaculty.Location = new Point(258, 299);
            btnAddFaculty.Name = "btnAddFaculty";
            btnAddFaculty.Size = new Size(133, 48);
            btnAddFaculty.TabIndex = 41;
            btnAddFaculty.Text = "Thêm mới";
            btnAddFaculty.UseVisualStyleBackColor = false;
            btnAddFaculty.Click += btnAddFaculty_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 84);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 47;
            label2.Text = "Tên khoa";
            // 
            // txtFacultyname
            // 
            txtFacultyname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFacultyname.Location = new Point(75, 132);
            txtFacultyname.Name = "txtFacultyname";
            txtFacultyname.Size = new Size(316, 31);
            txtFacultyname.TabIndex = 48;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(80, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1082, 573);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các khoa";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FacultyID, FacultyName, NumberOfClasses, NumberOfStudents, Edit, Delete });
            dataGridView1.Location = new Point(56, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(973, 460);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(715, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1209, 937);
            panel2.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnFind);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtFindFaculty);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(265, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(804, 131);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Gray;
            btnFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFind.ForeColor = SystemColors.ButtonHighlight;
            btnFind.Location = new Point(656, 54);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(92, 48);
            btnFind.TabIndex = 42;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(123, 54);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 49;
            label4.Text = "Nhập tên khoa";
            // 
            // txtFindFaculty
            // 
            txtFindFaculty.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFindFaculty.Location = new Point(270, 51);
            txtFindFaculty.Name = "txtFindFaculty";
            txtFindFaculty.Size = new Size(316, 31);
            txtFindFaculty.TabIndex = 50;
            // 
            // FacultyID
            // 
            FacultyID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FacultyID.DataPropertyName = "FacultyID";
            FacultyID.HeaderText = "Mã khoa";
            FacultyID.MinimumWidth = 6;
            FacultyID.Name = "FacultyID";
            FacultyID.Width = 110;
            // 
            // FacultyName
            // 
            FacultyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FacultyName.DataPropertyName = "FacultyName";
            FacultyName.HeaderText = "Tên khoa";
            FacultyName.MinimumWidth = 6;
            FacultyName.Name = "FacultyName";
            FacultyName.Width = 111;
            // 
            // NumberOfClasses
            // 
            NumberOfClasses.DataPropertyName = "NumberOfClasses";
            NumberOfClasses.HeaderText = "Số lớp";
            NumberOfClasses.MinimumWidth = 6;
            NumberOfClasses.Name = "NumberOfClasses";
            NumberOfClasses.ReadOnly = true;
            NumberOfClasses.Width = 125;
            // 
            // NumberOfStudents
            // 
            NumberOfStudents.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NumberOfStudents.DataPropertyName = "NumberOfStudents";
            NumberOfStudents.HeaderText = "Tổng số lượng sinh viên";
            NumberOfStudents.MinimumWidth = 6;
            NumberOfStudents.Name = "NumberOfStudents";
            NumberOfStudents.ReadOnly = true;
            NumberOfStudents.Width = 182;
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
            // fManageFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fManageFaculty";
            Text = "Quản lý khoa";
            WindowState = FormWindowState.Maximized;
            Activated += fManageFaculty_Activated;
            Load += fManageFaculty_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button btClose;
        private GroupBox groupBox1;
        private Button btnAddFaculty;
        private Label label3;
        private TextBox txtFacultyID;
        private Label label2;
        private TextBox txtFacultyname;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private GroupBox groupBox3;
        private Button btnFind;
        private Label label4;
        private TextBox txtFindFaculty;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn FacultyID;
        private DataGridViewTextBoxColumn FacultyName;
        private DataGridViewTextBoxColumn NumberOfClasses;
        private DataGridViewTextBoxColumn NumberOfStudents;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}