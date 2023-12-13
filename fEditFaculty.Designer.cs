namespace ScoreManagement
{
    partial class fEditFaculty
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
            btSave = new Button();
            txtFacultyName = new TextBox();
            label2 = new Label();
            btClose = new Button();
            label3 = new Label();
            txtFacultyID = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkSlateGray;
            btSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = SystemColors.ControlLightLight;
            btSave.Location = new Point(79, 213);
            btSave.Name = "btSave";
            btSave.Size = new Size(128, 59);
            btSave.TabIndex = 49;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // txtFacultyName
            // 
            txtFacultyName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFacultyName.Location = new Point(158, 48);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.Size = new Size(399, 31);
            txtFacultyName.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 48);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 46;
            label2.Text = "Tên khoa";
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(320, 213);
            btClose.Name = "btClose";
            btClose.Size = new Size(128, 59);
            btClose.TabIndex = 50;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 125);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 51;
            label3.Text = "Mã khoa";
            // 
            // txtFacultyID
            // 
            txtFacultyID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFacultyID.Location = new Point(158, 122);
            txtFacultyID.Name = "txtFacultyID";
            txtFacultyID.Size = new Size(196, 31);
            txtFacultyID.TabIndex = 52;
            // 
            // fEditFalcuty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 328);
            Controls.Add(label3);
            Controls.Add(txtFacultyID);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(txtFacultyName);
            Controls.Add(label2);
            Name = "fEditFalcuty";
            Text = "Sửa đổi khoa";
            Load += fEditFalcuty_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSave;
        private TextBox txtFacultyName;
        private Label label2;
        private Button btClose;
        private Label label3;
        private TextBox txtFacultyID;
        private ToolTip toolTip1;
    }
}