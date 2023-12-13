namespace ScoreManagement
{
    partial class fManageSubject
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
            btClose = new Button();
            groupBox1 = new GroupBox();
            cbFaculty = new ComboBox();
            label3 = new Label();
            btnAdd = new Button();
            label2 = new Label();
            txtSubjectName = new TextBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            toolTip1 = new ToolTip(components);
            SubjectID = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            FacultyID = new DataGridViewTextBoxColumn();
            NumberOfClassSubjects = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
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
            label1.Size = new Size(1924, 110);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ MÔN HỌC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btClose);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 942);
            panel1.TabIndex = 2;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(537, 708);
            btClose.Name = "btClose";
            btClose.Size = new Size(110, 47);
            btClose.TabIndex = 46;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(cbFaculty);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSubjectName);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(75, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 574);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập mới môn học";
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(217, 206);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(286, 33);
            cbFaculty.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(144, 209);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 63;
            label3.Text = "Khoa";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gray;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(217, 362);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 50);
            btnAdd.TabIndex = 61;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 137);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 58;
            label2.Text = "Tên môn học ";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(217, 134);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(286, 31);
            txtSubjectName.TabIndex = 57;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(716, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(1208, 942);
            panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(70, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1085, 777);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các môn học";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SubjectID, SubjectName, FacultyID, NumberOfClassSubjects, Edit, Delete });
            dataGridView1.Location = new Point(64, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(958, 644);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // SubjectName
            // 
            SubjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "Tên môn học";
            SubjectName.MinimumWidth = 6;
            SubjectName.Name = "SubjectName";
            SubjectName.Width = 143;
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
            // NumberOfClassSubjects
            // 
            NumberOfClassSubjects.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NumberOfClassSubjects.DataPropertyName = "NumberOfClassSubjects";
            NumberOfClassSubjects.HeaderText = "Số lớp học phần";
            NumberOfClassSubjects.MinimumWidth = 6;
            NumberOfClassSubjects.Name = "NumberOfClassSubjects";
            NumberOfClassSubjects.Width = 172;
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
            // fManageSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "fManageSubject";
            Text = "Quản lý môn học";
            WindowState = FormWindowState.Maximized;
            Activated += fManageSubject_Activated;
            Load += fManageSubject_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label2;
        private TextBox txtSubjectName;
        private Button btnAdd;
        private Button btClose;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
        private ComboBox cbFaculty;
        private Label label3;
        private DataGridViewTextBoxColumn SubjectID;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn FacultyID;
        private DataGridViewTextBoxColumn NumberOfClassSubjects;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}