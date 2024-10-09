namespace ArticleManagementUseEvent
{
    partial class frmShowArticles
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
            dgv1 = new DataGridView();
            lblNumRecords = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Articles";
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AllowUserToOrderColumns = true;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(24, 47);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.Size = new Size(494, 183);
            dgv1.TabIndex = 1;
            // 
            // lblNumRecords
            // 
            lblNumRecords.AutoSize = true;
            lblNumRecords.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumRecords.Location = new Point(31, 254);
            lblNumRecords.Name = "lblNumRecords";
            lblNumRecords.Size = new Size(77, 19);
            lblNumRecords.TabIndex = 2;
            lblNumRecords.Text = "Record: ??";
            // 
            // frmShowArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 278);
            Controls.Add(lblNumRecords);
            Controls.Add(dgv1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowArticles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShowArticles";
            Load += frmShowArticles_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv1;
        private Label lblNumRecords;
    }
}