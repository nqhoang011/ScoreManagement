namespace ScoreManagement
{
    partial class fEditScore
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
            label5 = new Label();
            txtMidtermScore = new TextBox();
            label6 = new Label();
            txtFinalScore = new TextBox();
            btSave = new Button();
            btClose = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 38);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 55;
            label5.Text = "Điểm quá trình";
            // 
            // txtMidtermScore
            // 
            txtMidtermScore.Location = new Point(45, 78);
            txtMidtermScore.Name = "txtMidtermScore";
            txtMidtermScore.Size = new Size(179, 27);
            txtMidtermScore.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(330, 38);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 56;
            label6.Text = "Điểm thi";
            // 
            // txtFinalScore
            // 
            txtFinalScore.Location = new Point(330, 78);
            txtFinalScore.Name = "txtFinalScore";
            txtFinalScore.Size = new Size(179, 27);
            txtFinalScore.TabIndex = 54;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkSlateGray;
            btSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = SystemColors.ControlLightLight;
            btSave.Location = new Point(114, 182);
            btSave.Name = "btSave";
            btSave.Size = new Size(110, 47);
            btSave.TabIndex = 57;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkSlateGray;
            btClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlLightLight;
            btClose.Location = new Point(299, 182);
            btClose.Name = "btClose";
            btClose.Size = new Size(110, 47);
            btClose.TabIndex = 58;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // fEditScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 278);
            Controls.Add(btSave);
            Controls.Add(btClose);
            Controls.Add(label5);
            Controls.Add(txtMidtermScore);
            Controls.Add(label6);
            Controls.Add(txtFinalScore);
            Name = "fEditScore";
            Text = "Sửa điểm";
            Load += fEditScore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtMidtermScore;
        private Label label6;
        private TextBox txtFinalScore;
        private Button btSave;
        private Button btClose;
        private ToolTip toolTip1;
    }
}