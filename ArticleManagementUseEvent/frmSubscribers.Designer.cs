namespace ArticleManagementUseEvent
{
    partial class frmSubscribers
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
            lblSubscriberNum = new Label();
            btnSubscribe = new Button();
            button1 = new Button();
            dgv1 = new DataGridView();
            lblNumRecords = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(116, 24);
            label1.Name = "label1";
            label1.Size = new Size(203, 26);
            label1.TabIndex = 0;
            label1.Text = "Subscriber Number:";
            // 
            // lblSubscriberNum
            // 
            lblSubscriberNum.AutoSize = true;
            lblSubscriberNum.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubscriberNum.ForeColor = Color.FromArgb(0, 192, 0);
            lblSubscriberNum.Location = new Point(325, 24);
            lblSubscriberNum.Name = "lblSubscriberNum";
            lblSubscriberNum.Size = new Size(24, 26);
            lblSubscriberNum.TabIndex = 1;
            lblSubscriberNum.Text = "1";
            // 
            // btnSubscribe
            // 
            btnSubscribe.Font = new Font("Microsoft YaHei", 9.75F);
            btnSubscribe.Location = new Point(12, 77);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(106, 34);
            btnSubscribe.TabIndex = 2;
            btnSubscribe.Text = "Subscribe";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei", 9.75F);
            button1.Location = new Point(138, 77);
            button1.Name = "button1";
            button1.Size = new Size(106, 34);
            button1.TabIndex = 3;
            button1.Text = "UnSubscribe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AllowUserToOrderColumns = true;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(12, 129);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.Size = new Size(506, 225);
            dgv1.TabIndex = 4;
            // 
            // lblNumRecords
            // 
            lblNumRecords.AutoSize = true;
            lblNumRecords.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumRecords.Location = new Point(12, 357);
            lblNumRecords.Name = "lblNumRecords";
            lblNumRecords.Size = new Size(77, 19);
            lblNumRecords.TabIndex = 5;
            lblNumRecords.Text = "Record: ??";
            // 
            // frmSubscribers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 384);
            Controls.Add(lblNumRecords);
            Controls.Add(dgv1);
            Controls.Add(button1);
            Controls.Add(btnSubscribe);
            Controls.Add(lblSubscriberNum);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmSubscribers";
            Text = "Subscribers";
            Load += SubscriberOne_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSubscriberNum;
        private Button btnSubscribe;
        private Button button1;
        private DataGridView dgv1;
        private Label lblNumRecords;
    }
}