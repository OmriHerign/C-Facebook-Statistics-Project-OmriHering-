namespace BasicFacebookFeatures
{
    partial class FormTopResponderDetails
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
            this.pictureOfResponder = new System.Windows.Forms.PictureBox();
            this.numOfComments = new System.Windows.Forms.Label();
            this.numOfLikes = new System.Windows.Forms.Label();
            this.numOfCommentsTitle = new System.Windows.Forms.Label();
            this.numOfLikesTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfResponder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOfResponder
            // 
            this.pictureOfResponder.Location = new System.Drawing.Point(70, 34);
            this.pictureOfResponder.Name = "pictureOfResponder";
            this.pictureOfResponder.Size = new System.Drawing.Size(139, 114);
            this.pictureOfResponder.TabIndex = 3;
            this.pictureOfResponder.TabStop = false;
           // this.pictureOfResponder.Click += new System.EventHandler(this.pictureOfResponder_Click);
            // 
            // numOfComments
            // 
            this.numOfComments.AutoSize = true;
            this.numOfComments.Location = new System.Drawing.Point(23, 182);
            this.numOfComments.Name = "numOfComments";
            this.numOfComments.Size = new System.Drawing.Size(95, 13);
            this.numOfComments.TabIndex = 4;
            this.numOfComments.Text = "Num Of Comments";
            // 
            // numOfLikes
            // 
            this.numOfLikes.AutoSize = true;
            this.numOfLikes.Location = new System.Drawing.Point(161, 182);
            this.numOfLikes.Name = "numOfLikes";
            this.numOfLikes.Size = new System.Drawing.Size(69, 13);
            this.numOfLikes.TabIndex = 5;
            this.numOfLikes.Text = "num Of Likes";
            // 
            // numOfCommentsTitle
            // 
            this.numOfCommentsTitle.AutoSize = true;
            this.numOfCommentsTitle.Location = new System.Drawing.Point(23, 169);
            this.numOfCommentsTitle.Name = "numOfCommentsTitle";
            this.numOfCommentsTitle.Size = new System.Drawing.Size(95, 13);
            this.numOfCommentsTitle.TabIndex = 6;
            this.numOfCommentsTitle.Text = "Num Of Comments";
            // 
            // numOfLikesTitle
            // 
            this.numOfLikesTitle.AutoSize = true;
            this.numOfLikesTitle.Location = new System.Drawing.Point(161, 169);
            this.numOfLikesTitle.Name = "numOfLikesTitle";
            this.numOfLikesTitle.Size = new System.Drawing.Size(69, 13);
            this.numOfLikesTitle.TabIndex = 7;
            this.numOfLikesTitle.Text = "num Of Likes";
            // 
            // TopResponderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.numOfLikesTitle);
            this.Controls.Add(this.numOfCommentsTitle);
            this.Controls.Add(this.numOfLikes);
            this.Controls.Add(this.numOfComments);
            this.Controls.Add(this.pictureOfResponder);
            this.Name = "TopResponderDetailsForm";
            this.Text = "TopResponderDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfResponder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOfResponder;
        private System.Windows.Forms.Label numOfComments;
        private System.Windows.Forms.Label numOfLikes;
        private System.Windows.Forms.Label numOfCommentsTitle;
        private System.Windows.Forms.Label numOfLikesTitle;
    }
}