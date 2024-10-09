namespace ArticleManagementUseEvent
{
    partial class frmPublishANewArticle
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
            label2 = new Label();
            label3 = new Label();
            tbTitle = new TextBox();
            tbContent = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 31);
            label1.TabIndex = 1;
            label1.Text = "Publish A New Article";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 60);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 138);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 3;
            label3.Text = "Content";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(31, 94);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(372, 23);
            tbTitle.TabIndex = 4;
            // 
            // tbContent
            // 
            tbContent.Location = new Point(31, 173);
            tbContent.Multiline = true;
            tbContent.Name = "tbContent";
            tbContent.Size = new Size(372, 131);
            tbContent.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(307, 310);
            button1.Name = "button1";
            button1.Size = new Size(96, 40);
            button1.TabIndex = 6;
            button1.Text = "Publish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmPublishANewArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 359);
            Controls.Add(button1);
            Controls.Add(tbContent);
            Controls.Add(tbTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmPublishANewArticle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPublishANewArticle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbTitle;
        private TextBox tbContent;
        private Button button1;
    }
}