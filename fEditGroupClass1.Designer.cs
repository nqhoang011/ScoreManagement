namespace ScoreManagement
{
    partial class fEditGroupClass1
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
            cbFaculty = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtGroupClassName = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gray;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(93, 163);
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
            btnClose.Location = new Point(272, 163);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(133, 50);
            btnClose.TabIndex = 73;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(119, 34);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(286, 28);
            cbFaculty.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 37);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 71;
            label3.Text = "Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 100);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 70;
            label2.Text = "Lớp";
            // 
            // txtGroupClassName
            // 
            txtGroupClassName.Location = new Point(119, 98);
            txtGroupClassName.Name = "txtGroupClassName";
            txtGroupClassName.Size = new Size(286, 27);
            txtGroupClassName.TabIndex = 69;
            // 
            // fEditGroupClass1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 297);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(cbFaculty);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtGroupClassName);
            Name = "fEditGroupClass1";
            Text = "Sửa đổi thông tin lớp";
            Load += fEditGroupClass1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private ComboBox cbFaculty;
        private Label label3;
        private Label label2;
        private TextBox txtGroupClassName;
    }
}