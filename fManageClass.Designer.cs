namespace ScoreManagement
{
    partial class fManageClass
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
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            FacultyID = new DataGridViewTextBoxColumn();
            ClassID = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            NumberOfStudents = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            btnFind = new Button();
            txtFindClass = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            btClose = new Button();
            groupBox2 = new GroupBox();
            txtGroupID = new TextBox();
            txtClassName = new TextBox();
            label6 = new Label();
            btnAddNew = new Button();
            label4 = new Label();
            label5 = new Label();
            cbFacultyID = new ComboBox();
            toolTip1 = new ToolTip(components);
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
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
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ LỚP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(642, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(1282, 943);
            panel3.TabIndex = 52;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(81, 237);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1100, 593);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách các lớp";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FacultyID, ClassID, ClassName, NumberOfStudents, Edit, Delete });
            dataGridView1.Location = new Point(66, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(964, 477);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // ClassID
            // 
            ClassID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClassID.DataPropertyName = "ClassID";
            ClassID.HeaderText = "Mã lớp";
            ClassID.MinimumWidth = 6;
            ClassID.Name = "ClassID";
            ClassID.ReadOnly = true;
            ClassID.Width = 97;
            // 
            // ClassName
            // 
            ClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClassName.DataPropertyName = "ClassName";
            ClassName.HeaderText = "Tên lớp";
            ClassName.MinimumWidth = 6;
            ClassName.Name = "ClassName";
            ClassName.Width = 98;
            // 
            // NumberOfStudents
            // 
            NumberOfStudents.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NumberOfStudents.DataPropertyName = "NumberOfStudents";
            NumberOfStudents.HeaderText = "Sĩ Số";
            NumberOfStudents.MinimumWidth = 6;
            NumberOfStudents.Name = "NumberOfStudents";
            NumberOfStudents.ReadOnly = true;
            NumberOfStudents.Width = 81;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(txtFindClass);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(81, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(949, 130);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm ";
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Gray;
            btnFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFind.ForeColor = SystemColors.ButtonHighlight;
            btnFind.Location = new Point(691, 49);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(92, 48);
            btnFind.TabIndex = 49;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtFindClass
            // 
            txtFindClass.Location = new Point(304, 58);
            txtFindClass.Name = "txtFindClass";
            txtFindClass.Size = new Size(293, 31);
            txtFindClass.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(193, 64);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 46;
            label3.Text = "Tên lớp";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btClose);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 943);
            panel2.TabIndex = 50;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(409, 591);
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
            groupBox2.Controls.Add(txtGroupID);
            groupBox2.Controls.Add(txtClassName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnAddNew);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbFacultyID);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(87, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 418);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thêm lớp học mới";
            // 
            // txtGroupID
            // 
            txtGroupID.Location = new Point(203, 146);
            txtGroupID.Name = "txtGroupID";
            txtGroupID.Size = new Size(164, 31);
            txtGroupID.TabIndex = 50;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(203, 211);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(164, 31);
            txtClassName.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(92, 217);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 49;
            label6.Text = "Tên lớp";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.Gray;
            btnAddNew.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNew.ForeColor = SystemColors.ButtonHighlight;
            btnAddNew.Location = new Point(234, 297);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(133, 48);
            btnAddNew.TabIndex = 47;
            btnAddNew.Text = "Thêm mới";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(92, 77);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 45;
            label4.Text = "Mã khoa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(92, 149);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 46;
            label5.Text = "Mã lớp";
            // 
            // cbFacultyID
            // 
            cbFacultyID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFacultyID.FormattingEnabled = true;
            cbFacultyID.Location = new Point(203, 74);
            cbFacultyID.Name = "cbFacultyID";
            cbFacultyID.Size = new Size(164, 33);
            cbFacultyID.TabIndex = 32;
            // 
            // fManageClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(label1);
            Name = "fManageClass";
            Text = "Quản lý lớp";
            WindowState = FormWindowState.Maximized;
            Activated += fManageClass_Activated;
            Load += fManageClass_Load;
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txtFindClass;
        private Label label3;
        private Panel panel2;
        private Button btClose;
        private Button btSave;
        private GroupBox groupBox2;
        private TextBox txtClassName;
        private Label label6;
        private Button btnAddNew;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private ComboBox cbFacultyID;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button btnFind;
        private DataGridViewTextBoxColumn TenLop;
        private TextBox txtGroupID;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn FacultyID;
        private DataGridViewTextBoxColumn ClassID;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn NumberOfStudents;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}