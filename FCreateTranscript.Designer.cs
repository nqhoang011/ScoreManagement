namespace ScoreManagement
{
    partial class FCreateTranscript
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
            cbSubjectName = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbFacultyName = new ComboBox();
            cbClassSubjectName = new ComboBox();
            btnCreate = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 188);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 61;
            label2.Text = "Tên lớp HP";
            // 
            // cbSubjectName
            // 
            cbSubjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubjectName.FormattingEnabled = true;
            cbSubjectName.Location = new Point(157, 109);
            cbSubjectName.Name = "cbSubjectName";
            cbSubjectName.Size = new Size(268, 33);
            cbSubjectName.TabIndex = 59;
            cbSubjectName.SelectedIndexChanged += cbSubjectName_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 40);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 55;
            label4.Text = "Khoa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 112);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 56;
            label5.Text = "Môn học ";
            // 
            // cbFacultyName
            // 
            cbFacultyName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFacultyName.FormattingEnabled = true;
            cbFacultyName.Location = new Point(157, 37);
            cbFacultyName.Name = "cbFacultyName";
            cbFacultyName.Size = new Size(268, 33);
            cbFacultyName.TabIndex = 54;
            cbFacultyName.SelectedIndexChanged += cbFacultyName_SelectedIndexChanged;
            // 
            // cbClassSubjectName
            // 
            cbClassSubjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbClassSubjectName.FormattingEnabled = true;
            cbClassSubjectName.Location = new Point(157, 188);
            cbClassSubjectName.Name = "cbClassSubjectName";
            cbClassSubjectName.Size = new Size(268, 33);
            cbClassSubjectName.TabIndex = 62;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Gray;
            btnCreate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = SystemColors.ButtonHighlight;
            btnCreate.Location = new Point(292, 277);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(133, 48);
            btnCreate.TabIndex = 63;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(69, 277);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(133, 48);
            btnClose.TabIndex = 64;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FCreateTranscript
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 370);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(cbClassSubjectName);
            Controls.Add(label2);
            Controls.Add(cbSubjectName);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(cbFacultyName);
            Name = "FCreateTranscript";
            Text = "Tạo bảng điểm";
            Load += FCreateTranscript_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cbSubjectName;
        private Label label4;
        private Label label5;
        private ComboBox cbFacultyName;
        private ComboBox cbClassSubjectName;
        private Button btnCreate;
        private Button btnClose;
    }
}