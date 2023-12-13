namespace ScoreManagement
{
    partial class fEditSubject2
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
            btnSave = new Button();
            btnClose = new Button();
            label2 = new Label();
            txtSubjectName = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gray;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(141, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 50);
            btnSave.TabIndex = 74;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(353, 160);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(133, 50);
            btnClose.TabIndex = 73;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 83);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 70;
            label2.Text = "Tên môn học ";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(200, 80);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(286, 27);
            txtSubjectName.TabIndex = 69;
            // 
            // fEditSubject2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 287);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(txtSubjectName);
            Name = "fEditSubject2";
            Text = "Sửa đổi thông tin môn học";
            Load += fEditSubject2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private Label label2;
        private TextBox txtSubjectName;
    }
}