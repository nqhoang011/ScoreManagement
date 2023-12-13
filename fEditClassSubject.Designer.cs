namespace ScoreManagement
{
    partial class fEditClassSubject
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
            label3 = new Label();
            txtClassSubjectID = new TextBox();
            btClose = new Button();
            btSave = new Button();
            txtClassSubjectName = new TextBox();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 50);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 57;
            label3.Text = "Mã lớp";
            // 
            // txtClassSubjectID
            // 
            txtClassSubjectID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtClassSubjectID.Location = new Point(150, 47);
            txtClassSubjectID.Name = "txtClassSubjectID";
            txtClassSubjectID.Size = new Size(196, 31);
            txtClassSubjectID.TabIndex = 58;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(309, 200);
            btClose.Name = "btClose";
            btClose.Size = new Size(128, 59);
            btClose.TabIndex = 56;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkSlateGray;
            btSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = SystemColors.ControlLightLight;
            btSave.Location = new Point(68, 200);
            btSave.Name = "btSave";
            btSave.Size = new Size(128, 59);
            btSave.TabIndex = 55;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // txtClassSubjectName
            // 
            txtClassSubjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtClassSubjectName.Location = new Point(150, 122);
            txtClassSubjectName.Name = "txtClassSubjectName";
            txtClassSubjectName.Size = new Size(196, 31);
            txtClassSubjectName.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 122);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 53;
            label2.Text = "Tên lớp";
            // 
            // fEditClassSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 295);
            Controls.Add(label3);
            Controls.Add(txtClassSubjectID);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(txtClassSubjectName);
            Controls.Add(label2);
            Name = "fEditClassSubject";
            Text = "Sửa đổi lớp học phần";
            Load += fEditClassSubject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtClassSubjectID;
        private Button btClose;
        private Button btSave;
        private TextBox txtClassSubjectName;
        private Label label2;
        private ToolTip toolTip1;
    }
}