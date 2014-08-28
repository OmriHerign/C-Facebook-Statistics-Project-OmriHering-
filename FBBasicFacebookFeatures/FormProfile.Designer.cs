namespace BasicFacebookFeatures
{
    partial class FormProfile
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
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userPicture
            // 
            this.userPicture.Location = new System.Drawing.Point(24, 32);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(100, 111);
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(280, 32);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(77, 13);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "The First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(279, 65);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(78, 13);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "The Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Birthday:";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(279, 96);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(67, 13);
            this.birthday.TabIndex = 6;
            this.birthday.Text = "The Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sex:";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(279, 130);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(45, 13);
            this.sex.TabIndex = 8;
            this.sex.Text = "The sex";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "UserPicture";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 188);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPicture);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label label9;
    }
}