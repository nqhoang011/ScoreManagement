namespace ScoreManagement
{
    partial class fEditSubject1
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
            label2 = new Label();
            txtSubjectName = new TextBox();
            cbFaculty = new ComboBox();
            label3 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 106);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 60;
            label2.Text = "Tên môn học ";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(192, 103);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(286, 27);
            txtSubjectName.TabIndex = 59;
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(192, 42);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(286, 28);
            cbFaculty.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(119, 45);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 65;
            label3.Text = "Khoa";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(345, 171);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(133, 50);
            btnClose.TabIndex = 67;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gray;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(169, 171);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 50);
            btnSave.TabIndex = 68;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // fEditSubject1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 280);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(cbFaculty);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSubjectName);
            Name = "fEditSubject1";
            Text = "Sửa đổi thông tin môn học";
            Load += fEditSubject1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtSubjectName;
        private ComboBox cbFaculty;
        private Label label3;
        private Button btnClose;
        private Button btnSave;
    }
}