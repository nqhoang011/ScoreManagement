namespace ScoreManagement
{
    partial class fLookUpScore
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
            btnFind = new Button();
            txtStudentID = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            MSSV = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            MidtermScore = new DataGridViewTextBoxColumn();
            FinalScore = new DataGridViewTextBoxColumn();
            AverageScore = new DataGridViewTextBoxColumn();
            Failed = new DataGridViewCheckBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1924, 109);
            label1.TabIndex = 1;
            label1.Text = "TRA CỨU ĐIỂM SỐ ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Gray;
            btnFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFind.ForeColor = SystemColors.ButtonHighlight;
            btnFind.Location = new Point(486, 52);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(87, 43);
            btnFind.TabIndex = 56;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(240, 58);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(186, 27);
            txtStudentID.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(83, 61);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 54;
            label7.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtStudentID);
            groupBox2.Controls.Add(btnFind);
            groupBox2.Location = new Point(664, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(643, 138);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MSSV, StudentName, SubjectName, MidtermScore, FinalScore, AverageScore, Failed });
            dataGridView1.Location = new Point(58, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1509, 445);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(149, 410);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1635, 542);
            groupBox3.TabIndex = 59;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách ";
            // 
            // MSSV
            // 
            MSSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MSSV.DataPropertyName = "MSSV";
            MSSV.HeaderText = "MSSV";
            MSSV.MinimumWidth = 6;
            MSSV.Name = "MSSV";
            MSSV.Width = 88;
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
            // SubjectName
            // 
            SubjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "Môn học";
            SubjectName.MinimumWidth = 6;
            SubjectName.Name = "SubjectName";
            SubjectName.Width = 112;
            // 
            // MidtermScore
            // 
            MidtermScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MidtermScore.DataPropertyName = "MidtermScore";
            MidtermScore.HeaderText = "Điểm giữa kì";
            MidtermScore.MinimumWidth = 6;
            MidtermScore.Name = "MidtermScore";
            MidtermScore.ReadOnly = true;
            MidtermScore.Width = 141;
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
            // fLookUpScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.win11;
            ClientSize = new Size(1924, 1055);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "fLookUpScore";
            Text = "Tra cứu điểm nhanh";
            WindowState = FormWindowState.Maximized;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnFind;
        private TextBox txtStudentID;
        private Label label7;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn MidtermScore;
        private DataGridViewTextBoxColumn FinalScore;
        private DataGridViewTextBoxColumn AverageScore;
        private DataGridViewCheckBoxColumn Failed;
    }
}