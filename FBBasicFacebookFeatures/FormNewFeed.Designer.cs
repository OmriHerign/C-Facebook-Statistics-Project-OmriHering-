namespace BasicFacebookFeatures
{
    partial class FormNewFeed
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
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.fetchNewFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNewsFeed.DisplayMember = "name";
            this.listBoxNewsFeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.ItemHeight = 19;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(50, 69);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(566, 194);
            this.listBoxNewsFeed.TabIndex = 41;
            // 
            // fetchNewFeed
            // 
            this.fetchNewFeed.Location = new System.Drawing.Point(257, 27);
            this.fetchNewFeed.Name = "fetchNewFeed";
            this.fetchNewFeed.Size = new System.Drawing.Size(142, 23);
            this.fetchNewFeed.TabIndex = 42;
            this.fetchNewFeed.Text = "Fetch new feed";
            this.fetchNewFeed.UseVisualStyleBackColor = true;
            this.fetchNewFeed.Click += new System.EventHandler(this.fetchNewFeed_Click);
            // 
            // NewFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 325);
            this.Controls.Add(this.fetchNewFeed);
            this.Controls.Add(this.listBoxNewsFeed);
            this.Name = "NewFeedForm";
            this.Text = "NewFeedForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.Button fetchNewFeed;
    }
}