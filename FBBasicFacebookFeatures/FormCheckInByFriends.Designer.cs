namespace BasicFacebookFeatures
{
    partial class FormCheckInByFriends
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
            this.listOfFriends = new System.Windows.Forms.ListBox();
            this.listOfCheckins = new System.Windows.Forms.ListBox();
            this.listCheckinsDate = new System.Windows.Forms.ListBox();
            this.buttonWeb = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.CheckinButton = new System.Windows.Forms.Button();
            this.clearCheckins = new System.Windows.Forms.Button();
            this.friendsBoton = new System.Windows.Forms.Button();
            this.clearFriends = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfFriends
            // 
            this.listOfFriends.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listOfFriends.FormattingEnabled = true;
            this.listOfFriends.Location = new System.Drawing.Point(21, 37);
            this.listOfFriends.Name = "listOfFriends";
            this.listOfFriends.Size = new System.Drawing.Size(135, 290);
            this.listOfFriends.TabIndex = 2;
            this.listOfFriends.SelectedIndexChanged += new System.EventHandler(this.listOfFriends_SelectedIndexChanged);
            // 
            // listOfCheckins
            // 
            this.listOfCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listOfCheckins.DisplayMember = "name";
            this.listOfCheckins.FormattingEnabled = true;
            this.listOfCheckins.Location = new System.Drawing.Point(299, 37);
            this.listOfCheckins.Name = "listOfCheckins";
            this.listOfCheckins.Size = new System.Drawing.Size(174, 290);
            this.listOfCheckins.TabIndex = 5;
            // 
            // listCheckinsDate
            // 
            this.listCheckinsDate.FormattingEnabled = true;
            this.listCheckinsDate.Location = new System.Drawing.Point(479, 37);
            this.listCheckinsDate.Name = "listCheckinsDate";
            this.listCheckinsDate.Size = new System.Drawing.Size(120, 290);
            this.listCheckinsDate.TabIndex = 7;
            // 
            // buttonWeb
            // 
            this.buttonWeb.Location = new System.Drawing.Point(640, 37);
            this.buttonWeb.Name = "buttonWeb";
            this.buttonWeb.Size = new System.Drawing.Size(93, 23);
            this.buttonWeb.TabIndex = 9;
            this.buttonWeb.Text = "Open Website";
            this.buttonWeb.UseVisualStyleBackColor = true;
            this.buttonWeb.Click += new System.EventHandler(this.buttonWeb_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(640, 66);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(93, 23);
            this.buttonStatistics.TabIndex = 11;
            this.buttonStatistics.Text = "Statisctics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // CheckinButton
            // 
            this.CheckinButton.Location = new System.Drawing.Point(326, 333);
            this.CheckinButton.Name = "CheckinButton";
            this.CheckinButton.Size = new System.Drawing.Size(127, 23);
            this.CheckinButton.TabIndex = 12;
            this.CheckinButton.Text = "Friend Checkins";
            this.CheckinButton.UseVisualStyleBackColor = true;
            this.CheckinButton.Click += new System.EventHandler(this.CheckinButton_Click);
            // 
            // clearCheckins
            // 
            this.clearCheckins.Location = new System.Drawing.Point(326, 362);
            this.clearCheckins.Name = "clearCheckins";
            this.clearCheckins.Size = new System.Drawing.Size(127, 23);
            this.clearCheckins.TabIndex = 13;
            this.clearCheckins.Text = "Clear Checkins";
            this.clearCheckins.UseVisualStyleBackColor = true;
            this.clearCheckins.Click += new System.EventHandler(this.clearCheckins_Click);
            // 
            // friendsBoton
            // 
            this.friendsBoton.Location = new System.Drawing.Point(21, 333);
            this.friendsBoton.Name = "friendsBoton";
            this.friendsBoton.Size = new System.Drawing.Size(135, 23);
            this.friendsBoton.TabIndex = 14;
            this.friendsBoton.Text = "My Friends";
            this.friendsBoton.UseVisualStyleBackColor = true;
            this.friendsBoton.Click += new System.EventHandler(this.friendsBoton_Click);
            // 
            // clearFriends
            // 
            this.clearFriends.Location = new System.Drawing.Point(21, 362);
            this.clearFriends.Name = "clearFriends";
            this.clearFriends.Size = new System.Drawing.Size(135, 23);
            this.clearFriends.TabIndex = 15;
            this.clearFriends.Text = "Clear Friends";
            this.clearFriends.UseVisualStyleBackColor = true;
            this.clearFriends.Click += new System.EventHandler(this.clearFriends_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(173, 37);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(100, 155);
            this.pictureBoxFriend.TabIndex = 16;
            this.pictureBoxFriend.TabStop = false;
            // 
            // FormCheckInByFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 420);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.clearFriends);
            this.Controls.Add(this.friendsBoton);
            this.Controls.Add(this.clearCheckins);
            this.Controls.Add(this.CheckinButton);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonWeb);
            this.Controls.Add(this.listCheckinsDate);
            this.Controls.Add(this.listOfCheckins);
            this.Controls.Add(this.listOfFriends);
            this.Name = "FormCheckInByFriends";
            this.Text = "FormCheckInByFriends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfFriends;
        private System.Windows.Forms.ListBox listOfCheckins;
        private System.Windows.Forms.ListBox listCheckinsDate;
        private System.Windows.Forms.Button buttonWeb;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button CheckinButton;
        private System.Windows.Forms.Button clearCheckins;
        private System.Windows.Forms.Button friendsBoton;
        private System.Windows.Forms.Button clearFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
    }
}