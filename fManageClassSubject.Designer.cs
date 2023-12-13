namespace ScoreManagement
{
    partial class fManageClassSubject
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
            panel2 = new Panel();
            btClose = new Button();
            groupBox2 = new GroupBox();
            txtClassSubjectName = new TextBox();
            label2 = new Label();
            cbSubjectName = new ComboBox();
            txtClassSubjectID = new TextBox();
            label6 = new Label();
            btnAddNew = new Button();
            label4 = new Label();
            label5 = new Label();
            cbFacultyName = new ComboBox();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            cbFindSubject = new ComboBox();
            label3 = new Label();
            label7 = new Label();
            cbFindFaculty = new ComboBox();
            btnFind = new Button();
            toolTip1 = new ToolTip(components);
            FacultyID = new DataGridViewTextBoxColumn();
            ClassSubjectID = new DataGridViewTextBoxColumn();
            ClassSubjectName = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            NumberOfStudents = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
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
            label1.Size = new Size(1924, 112);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ LỚP HỌC PHẦN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btClose);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 943);
            panel2.TabIndex = 51;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(399, 668);
            btClose.Name = "btClose";
            btClose.Size = new Size(128, 59);
            btClose.TabIndex = 52;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(txtClassSubjectName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbSubjectName);
            groupBox2.Controls.Add(txtClassSubjectID);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnAddNew);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbFacultyName);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(57, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(509, 521);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thêm lớp học phần";
            // 
            // txtClassSubjectName
            // 
            txtClassSubjectName.Location = new Point(177, 278);
            txtClassSubjectName.Name = "txtClassSubjectName";
            txtClassSubjectName.Size = new Size(164, 31);
            txtClassSubjectName.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 281);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 53;
            label2.Text = "Tên lớp HP";
            // 
            // cbSubjectName
            // 
            cbSubjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubjectName.FormattingEnabled = true;
            cbSubjectName.Location = new Point(177, 141);
            cbSubjectName.Name = "cbSubjectName";
            cbSubjectName.Size = new Size(268, 33);
            cbSubjectName.TabIndex = 51;
            cbSubjectName.SelectedIndexChanged += cbSubjectName_SelectedIndexChanged;
            // 
            // txtClassSubjectID
            // 
            txtClassSubjectID.Location = new Point(177, 212);
            txtClassSubjectID.Name = "txtClassSubjectID";
            txtClassSubjectID.Size = new Size(164, 31);
            txtClassSubjectID.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(60, 215);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 49;
            label6.Text = "Mã lớp HP";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.Gray;
            btnAddNew.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNew.ForeColor = SystemColors.ButtonHighlight;
            btnAddNew.Location = new Point(203, 402);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(133, 48);
            btnAddNew.TabIndex = 47;
            btnAddNew.Text = "Thêm mới";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 72);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 45;
            label4.Text = "Khoa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 144);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 46;
            label5.Text = "Môn học ";
            // 
            // cbFacultyName
            // 
            cbFacultyName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFacultyName.FormattingEnabled = true;
            cbFacultyName.Location = new Point(177, 69);
            cbFacultyName.Name = "cbFacultyName";
            cbFacultyName.Size = new Size(268, 33);
            cbFacultyName.TabIndex = 32;
            cbFacultyName.SelectedIndexChanged += cbFacultyName_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(642, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(1282, 943);
            panel3.TabIndex = 53;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(81, 237);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1100, 593);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách các lớp học phần";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FacultyID, ClassSubjectID, ClassSubjectName, ClassName, NumberOfStudents, Edit, Delete });
            dataGridView1.Location = new Point(66, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(964, 477);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbFindSubject);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbFindFaculty);
            groupBox1.Controls.Add(btnFind);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(81, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1100, 138);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm ";
            // 
            // cbFindSubject
            // 
            cbFindSubject.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFindSubject.FormattingEnabled = true;
            cbFindSubject.Location = new Point(611, 61);
            cbFindSubject.Name = "cbFindSubject";
            cbFindSubject.Size = new Size(268, 33);
            cbFindSubject.TabIndex = 53;
            cbFindSubject.SelectedIndexChanged += cbFindSubject_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(494, 64);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 52;
            label3.Text = "Môn học ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(77, 64);
            label7.Name = "label7";
            label7.Size = new Size(52, 25);
            label7.TabIndex = 51;
            label7.Text = "Khoa";
            // 
            // cbFindFaculty
            // 
            cbFindFaculty.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFindFaculty.FormattingEnabled = true;
            cbFindFaculty.Location = new Point(148, 61);
            cbFindFaculty.Name = "cbFindFaculty";
            cbFindFaculty.Size = new Size(268, 33);
            cbFindFaculty.TabIndex = 50;
            cbFindFaculty.SelectedIndexChanged += cbFindFaculty_SelectedIndexChanged;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Gray;
            btnFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFind.ForeColor = SystemColors.ButtonHighlight;
            btnFind.Location = new Point(956, 64);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(92, 48);
            btnFind.TabIndex = 49;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // FacultyID
            // 
            FacultyID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FacultyID.DataPropertyName = "FacultyID";
            FacultyID.HeaderText = "Mã khoa";
            FacultyID.MinimumWidth = 6;
            FacultyID.Name = "FacultyID";
            FacultyID.ReadOnly = true;
            FacultyID.Width = 110;
            // 
            // ClassSubjectID
            // 
            ClassSubjectID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClassSubjectID.DataPropertyName = "ClassSubjectID";
            ClassSubjectID.HeaderText = "Mã lớp học phần";
            ClassSubjectID.MinimumWidth = 6;
            ClassSubjectID.Name = "ClassSubjectID";
            ClassSubjectID.Width = 176;
            // 
            // ClassSubjectName
            // 
            ClassSubjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClassSubjectName.DataPropertyName = "ClassSubjectName";
            ClassSubjectName.HeaderText = "Môn học";
            ClassSubjectName.MinimumWidth = 6;
            ClassSubjectName.Name = "ClassSubjectName";
            ClassSubjectName.ReadOnly = true;
            ClassSubjectName.Width = 112;
            // 
            // ClassName
            // 
            ClassName.DataPropertyName = "ClassName";
            ClassName.HeaderText = "Tên lớp";
            ClassName.MinimumWidth = 6;
            ClassName.Name = "ClassName";
            ClassName.Width = 125;
            // 
            // NumberOfStudents
            // 
            NumberOfStudents.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NumberOfStudents.DataPropertyName = "NumberOfStudents";
            NumberOfStudents.HeaderText = "Số sinh viên";
            NumberOfStudents.MinimumWidth = 6;
            NumberOfStudents.Name = "NumberOfStudents";
            NumberOfStudents.ReadOnly = true;
            NumberOfStudents.Width = 136;
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
            // fManageClassSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "fManageClassSubject";
            Text = "Quản lý lớp học phần";
            WindowState = FormWindowState.Maximized;
            Activated += fManageClassSubject_Activated;
            Load += fManageClassSubject_Load;
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button btClose;
        private GroupBox groupBox2;
        private TextBox txtClassSubjectID;
        private Label label6;
        private Button btnAddNew;
        private Label label4;
        private Label label5;
        private ComboBox cbFacultyName;
        private Panel panel3;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnFind;
        private ComboBox cbSubjectName;
        private TextBox txtClassSubjectName;
        private Label label2;
        private ComboBox cbFindSubject;
        private Label label3;
        private Label label7;
        private ComboBox cbFindFaculty;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn FacultyID;
        private DataGridViewTextBoxColumn ClassSubjectID;
        private DataGridViewTextBoxColumn ClassSubjectName;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn NumberOfStudents;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}