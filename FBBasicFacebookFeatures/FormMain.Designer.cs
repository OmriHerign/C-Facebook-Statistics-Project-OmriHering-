namespace BasicFacebookFeatures.WithSingltonAppSettings
{
    partial class checkInByFriends
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
        /// 
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            this.profilePictureOfUser = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.friendsListButton = new System.Windows.Forms.Button();
            this.UserProfile = new System.Windows.Forms.Label();
            this.myProfile = new System.Windows.Forms.Button();
            this.newFeed = new System.Windows.Forms.Button();
            this.fetchEvent = new System.Windows.Forms.Button();
            this.fetchCheckIn = new System.Windows.Forms.Button();
            this.topResponderButton = new System.Windows.Forms.Button();
            this.checkInButton = new System.Windows.Forms.Button();
            this.allNewFeed = new System.Windows.Forms.ListBox();
            this.pictureBoxSelectedNewsFeedPhoto = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureOfUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedNewsFeedPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureOfUser
            // 
            this.profilePictureOfUser.Location = new System.Drawing.Point(12, 57);
            this.profilePictureOfUser.Name = "profilePictureOfUser";
            this.profilePictureOfUser.Size = new System.Drawing.Size(200, 156);
            this.profilePictureOfUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureOfUser.TabIndex = 41;
            this.profilePictureOfUser.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.Location = new System.Drawing.Point(22, 235);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(124, 43);
            this.buttonSetStatus.TabIndex = 46;
            this.buttonSetStatus.Text = "Post status";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // friendsListButton
            // 
            this.friendsListButton.Location = new System.Drawing.Point(284, 23);
            this.friendsListButton.Name = "friendsListButton";
            this.friendsListButton.Size = new System.Drawing.Size(124, 43);
            this.friendsListButton.TabIndex = 51;
            this.friendsListButton.Text = "View Friends list";
            this.friendsListButton.UseVisualStyleBackColor = true;
            this.friendsListButton.Click += new System.EventHandler(this.friendsListButton_Click);
            // 
            // UserProfile
            // 
            this.UserProfile.AutoSize = true;
            this.UserProfile.Location = new System.Drawing.Point(74, 38);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Size = new System.Drawing.Size(61, 13);
            this.UserProfile.TabIndex = 52;
            this.UserProfile.Text = "User Profile";
            // 
            // myProfile
            // 
            this.myProfile.Location = new System.Drawing.Point(284, 96);
            this.myProfile.Name = "myProfile";
            this.myProfile.Size = new System.Drawing.Size(124, 43);
            this.myProfile.TabIndex = 53;
            this.myProfile.Text = "View My Profile";
            this.myProfile.UseVisualStyleBackColor = true;
            this.myProfile.Click += new System.EventHandler(this.myProfile_Click);
            // 
            // newFeed
            // 
            this.newFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newFeed.Location = new System.Drawing.Point(169, 235);
            this.newFeed.Name = "newFeed";
            this.newFeed.Size = new System.Drawing.Size(124, 43);
            this.newFeed.TabIndex = 54;
            this.newFeed.Text = "Fetch Feed";
            this.newFeed.UseVisualStyleBackColor = true;
            this.newFeed.Click += new System.EventHandler(this.newFeed_Click);
            // 
            // fetchEvent
            // 
            this.fetchEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fetchEvent.Location = new System.Drawing.Point(169, 308);
            this.fetchEvent.Name = "fetchEvent";
            this.fetchEvent.Size = new System.Drawing.Size(124, 43);
            this.fetchEvent.TabIndex = 55;
            this.fetchEvent.Text = "Fetch Event";
            this.fetchEvent.UseVisualStyleBackColor = true;
            this.fetchEvent.Click += new System.EventHandler(this.fetchEvent_Click);
            // 
            // fetchCheckIn
            // 
            this.fetchCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fetchCheckIn.Location = new System.Drawing.Point(88, 361);
            this.fetchCheckIn.Name = "fetchCheckIn";
            this.fetchCheckIn.Size = new System.Drawing.Size(124, 43);
            this.fetchCheckIn.TabIndex = 56;
            this.fetchCheckIn.Text = "Fetch CheeckIn";
            this.fetchCheckIn.UseVisualStyleBackColor = true;
            this.fetchCheckIn.Click += new System.EventHandler(this.fetchCheckIn_Click);
            // 
            // topResponderButton
            // 
            this.topResponderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topResponderButton.Location = new System.Drawing.Point(22, 308);
            this.topResponderButton.Name = "topResponderButton";
            this.topResponderButton.Size = new System.Drawing.Size(124, 43);
            this.topResponderButton.TabIndex = 57;
            this.topResponderButton.Text = "Top Responder";
            this.topResponderButton.UseVisualStyleBackColor = true;
            this.topResponderButton.Click += new System.EventHandler(this.topResponderButton_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(284, 161);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(124, 43);
            this.checkInButton.TabIndex = 58;
            this.checkInButton.Text = "CheckIn by Friends";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // allNewFeed
            // 
            this.allNewFeed.FormattingEnabled = true;
            this.allNewFeed.Location = new System.Drawing.Point(689, 12);
            this.allNewFeed.Name = "allNewFeed";
            this.allNewFeed.Size = new System.Drawing.Size(381, 381);
            this.allNewFeed.TabIndex = 59;
            this.allNewFeed.SelectedIndexChanged += new System.EventHandler(this.allNewFeed_SelectedIndexChanged);
            // 
            // pictureBoxSelectedNewsFeedPhoto
            // 
            this.pictureBoxSelectedNewsFeedPhoto.Location = new System.Drawing.Point(476, 14);
            this.pictureBoxSelectedNewsFeedPhoto.Name = "pictureBoxSelectedNewsFeedPhoto";
            this.pictureBoxSelectedNewsFeedPhoto.Size = new System.Drawing.Size(198, 199);
            this.pictureBoxSelectedNewsFeedPhoto.TabIndex = 60;
            this.pictureBoxSelectedNewsFeedPhoto.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(394, 244);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(267, 70);
            this.textBoxStatus.TabIndex = 61;
            // 
            // checkInByFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 430);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.pictureBoxSelectedNewsFeedPhoto);
            this.Controls.Add(this.allNewFeed);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.topResponderButton);
            this.Controls.Add(this.fetchCheckIn);
            this.Controls.Add(this.fetchEvent);
            this.Controls.Add(this.newFeed);
            this.Controls.Add(this.myProfile);
            this.Controls.Add(this.UserProfile);
            this.Controls.Add(this.friendsListButton);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.profilePictureOfUser);
            this.Controls.Add(this.buttonLogin);
            this.Name = "checkInByFriends";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureOfUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedNewsFeedPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureOfUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.Button friendsListButton;
        private System.Windows.Forms.Label UserProfile;
        private System.Windows.Forms.Button myProfile;
        private System.Windows.Forms.Button newFeed;
        private System.Windows.Forms.Button fetchEvent;
        private System.Windows.Forms.Button fetchCheckIn;
        private System.Windows.Forms.Button topResponderButton;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.ListBox allNewFeed;
        private System.Windows.Forms.PictureBox pictureBoxSelectedNewsFeedPhoto;
        private System.Windows.Forms.TextBox textBoxStatus;
    }
}

