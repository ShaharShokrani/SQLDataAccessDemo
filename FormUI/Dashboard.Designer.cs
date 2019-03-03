namespace FormUI
{
    partial class Dashboard
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
            this.postsFoundListbox = new System.Windows.Forms.ListBox();
            this.postTitleText = new System.Windows.Forms.TextBox();
            this.postTitle = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postsFoundListbox
            // 
            this.postsFoundListbox.FormattingEnabled = true;
            this.postsFoundListbox.Location = new System.Drawing.Point(14, 129);
            this.postsFoundListbox.Margin = new System.Windows.Forms.Padding(2);
            this.postsFoundListbox.Name = "postsFoundListbox";
            this.postsFoundListbox.Size = new System.Drawing.Size(170, 173);
            this.postsFoundListbox.TabIndex = 0;
            // 
            // postTitleText
            // 
            this.postTitleText.Location = new System.Drawing.Point(66, 76);
            this.postTitleText.Margin = new System.Windows.Forms.Padding(2);
            this.postTitleText.Name = "postTitleText";
            this.postTitleText.Size = new System.Drawing.Size(118, 20);
            this.postTitleText.TabIndex = 1;
            // 
            // postTitle
            // 
            this.postTitle.AutoSize = true;
            this.postTitle.Location = new System.Drawing.Point(11, 79);
            this.postTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postTitle.Name = "postTitle";
            this.postTitle.Size = new System.Drawing.Size(51, 13);
            this.postTitle.TabIndex = 2;
            this.postTitle.Text = "Post Title";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(14, 101);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 346);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.postTitle);
            this.Controls.Add(this.postTitleText);
            this.Controls.Add(this.postsFoundListbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox postsFoundListbox;
        private System.Windows.Forms.TextBox postTitleText;
        private System.Windows.Forms.Label postTitle;
        private System.Windows.Forms.Button searchButton;
    }
}

