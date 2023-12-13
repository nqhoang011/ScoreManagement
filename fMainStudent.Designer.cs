namespace ScoreManagement
{
    partial class fMainStudent
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
            menuStrip1 = new MenuStrip();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtThôngTinToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtClass = new TextBox();
            label4 = new Label();
            dtDateOfBirth = new DateTimePicker();
            txtGender = new TextBox();
            txtFaculty = new TextBox();
            label7 = new Label();
            btnEdit = new Button();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtStudentID = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            SubjectID = new DataGridViewTextBoxColumn();
            ClassSubjectID = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            MidtermScore = new DataGridViewTextBoxColumn();
            FinalScore = new DataGridViewTextBoxColumn();
            AverageScore = new DataGridViewTextBoxColumn();
            Failed = new DataGridViewCheckBoxColumn();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1924, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtThôngTinToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(100, 29);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            cậpNhậtThôngTinToolStripMenuItem.Size = new Size(247, 30);
            cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            cậpNhậtThôngTinToolStripMenuItem.Click += cậpNhậtThôngTinToolStripMenuItem_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(247, 30);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(247, 30);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(247, 30);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Image = Properties.Resources.win1;
            label1.Location = new Point(0, 33);
            label1.Name = "label1";
            label1.Size = new Size(624, 1022);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(txtClass);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtDateOfBirth);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(txtFaculty);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(47, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 714);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // txtClass
            // 
            txtClass.Enabled = false;
            txtClass.Location = new Point(184, 373);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(154, 31);
            txtClass.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 373);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 68;
            label4.Text = "Lớp";
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtDateOfBirth.Enabled = false;
            dtDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtDateOfBirth.Location = new Point(184, 250);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(154, 31);
            dtDateOfBirth.TabIndex = 67;
            // 
            // txtGender
            // 
            txtGender.Enabled = false;
            txtGender.Location = new Point(184, 187);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(97, 31);
            txtGender.TabIndex = 66;
            // 
            // txtFaculty
            // 
            txtFaculty.Enabled = false;
            txtFaculty.Location = new Point(184, 305);
            txtFaculty.Name = "txtFaculty";
            txtFaculty.Size = new Size(286, 31);
            txtFaculty.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 187);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 64;
            label7.Text = "Giới tính";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gray;
            btnEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(264, 481);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(206, 50);
            btnEdit.TabIndex = 61;
            btnEdit.Text = "Cập nhật thông tin";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 308);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 59;
            label3.Text = "Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 65);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 58;
            label2.Text = "Họ và tên";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(184, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 31);
            txtName.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 125);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 55;
            label5.Text = "Mã sinh viên";
            // 
            // txtStudentID
            // 
            txtStudentID.Enabled = false;
            txtStudentID.Location = new Point(184, 122);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(154, 31);
            txtStudentID.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 250);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 56;
            label6.Text = "Ngày sinh";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(624, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1300, 1022);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả học tập";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SubjectID, ClassSubjectID, SubjectName, MidtermScore, FinalScore, AverageScore, Failed });
            dataGridView1.Location = new Point(34, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1232, 683);
            dataGridView1.TabIndex = 0;
            // 
            // SubjectID
            // 
            SubjectID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubjectID.DataPropertyName = "SubjectID";
            SubjectID.HeaderText = "ID Môn học";
            SubjectID.MinimumWidth = 6;
            SubjectID.Name = "SubjectID";
            SubjectID.ReadOnly = true;
            SubjectID.Width = 161;
            // 
            // ClassSubjectID
            // 
            ClassSubjectID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClassSubjectID.DataPropertyName = "ClassSubjectID";
            ClassSubjectID.HeaderText = "ID lớp học";
            ClassSubjectID.MinimumWidth = 6;
            ClassSubjectID.Name = "ClassSubjectID";
            ClassSubjectID.ReadOnly = true;
            ClassSubjectID.Width = 148;
            // 
            // SubjectName
            // 
            SubjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "Tên môn học";
            SubjectName.MinimumWidth = 6;
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            SubjectName.Width = 173;
            // 
            // MidtermScore
            // 
            MidtermScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MidtermScore.DataPropertyName = "MidtermScore";
            MidtermScore.HeaderText = "Điểm giữa kỳ";
            MidtermScore.MinimumWidth = 6;
            MidtermScore.Name = "MidtermScore";
            MidtermScore.ReadOnly = true;
            MidtermScore.Width = 177;
            // 
            // FinalScore
            // 
            FinalScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FinalScore.DataPropertyName = "FinalScore";
            FinalScore.HeaderText = "Điểm cuối kì";
            FinalScore.MinimumWidth = 6;
            FinalScore.Name = "FinalScore";
            FinalScore.ReadOnly = true;
            FinalScore.Width = 169;
            // 
            // AverageScore
            // 
            AverageScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AverageScore.DataPropertyName = "AverageScore";
            AverageScore.HeaderText = "Điểm trung bình";
            AverageScore.MinimumWidth = 6;
            AverageScore.Name = "AverageScore";
            AverageScore.ReadOnly = true;
            AverageScore.Width = 211;
            // 
            // Failed
            // 
            Failed.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Failed.DataPropertyName = "Failed";
            Failed.HeaderText = "Trượt";
            Failed.MinimumWidth = 6;
            Failed.Name = "Failed";
            Failed.Width = 74;
            // 
            // fMainStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMainStudent";
            Text = "Trang sinh viên";
            WindowState = FormWindowState.Maximized;
            FormClosing += fMainStudent_FormClosing;
            Load += fMainStudent_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnEdit;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label5;
        private TextBox txtStudentID;
        private Label label6;
        private Label label7;
        private TextBox txtGender;
        private TextBox txtFaculty;
        private DateTimePicker dtDateOfBirth;
        private ComboBox comboBox3;
        private ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private GroupBox groupBox2;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SubjectID;
        private DataGridViewTextBoxColumn ClassSubjectID;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn MidtermScore;
        private DataGridViewTextBoxColumn FinalScore;
        private DataGridViewTextBoxColumn AverageScore;
        private DataGridViewCheckBoxColumn Failed;
        private Label label4;
        private TextBox txtClass;
    }
}