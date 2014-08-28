namespace BasicFacebookFeatures
{
    partial class FormFriendsList
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
            this.friendList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.friendsPicture = new System.Windows.Forms.PictureBox();
            this.viewProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // friendList
            // 
            this.friendList.FormattingEnabled = true;
            this.friendList.Location = new System.Drawing.Point(12, 45);
            this.friendList.Name = "friendList";
            this.friendList.Size = new System.Drawing.Size(142, 238);
            this.friendList.TabIndex = 0;
            this.friendList.SelectedIndexChanged += new System.EventHandler(this.friendList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Friends list";
            // 
            // friendsPicture
            // 
            this.friendsPicture.Location = new System.Drawing.Point(187, 45);
            this.friendsPicture.Name = "friendsPicture";
            this.friendsPicture.Size = new System.Drawing.Size(100, 96);
            this.friendsPicture.TabIndex = 2;
            this.friendsPicture.TabStop = false;
            // 
            // viewProfile
            // 
            this.viewProfile.Location = new System.Drawing.Point(187, 170);
            this.viewProfile.Name = "viewProfile";
            this.viewProfile.Size = new System.Drawing.Size(100, 23);
            this.viewProfile.TabIndex = 3;
            this.viewProfile.Text = "View Profile";
            this.viewProfile.UseVisualStyleBackColor = true;
            this.viewProfile.Click += new System.EventHandler(this.viewProfile_Click);
            // 
            // FriendsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 343);
            this.Controls.Add(this.viewProfile);
            this.Controls.Add(this.friendsPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.friendList);
            this.Name = "FriendsListForm";
            this.Text = "FriendsListForm";
            ((System.ComponentModel.ISupportInitialize)(this.friendsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox friendList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox friendsPicture;
        private System.Windows.Forms.Button viewProfile;
    }
}