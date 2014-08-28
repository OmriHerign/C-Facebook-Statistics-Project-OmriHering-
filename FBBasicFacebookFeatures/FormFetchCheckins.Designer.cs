namespace BasicFacebookFeatures
{
    partial class FormFetchCheckins
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
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.linkCheckins = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCheckins.DisplayMember = "name";
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.Location = new System.Drawing.Point(12, 77);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(396, 173);
            this.listBoxCheckins.TabIndex = 41;
            // 
            // linkCheckins
            // 
            this.linkCheckins.AutoSize = true;
            this.linkCheckins.LinkArea = new System.Windows.Forms.LinkArea(0, 14);
            this.linkCheckins.Location = new System.Drawing.Point(103, 25);
            this.linkCheckins.Name = "linkCheckins";
            this.linkCheckins.Size = new System.Drawing.Size(193, 30);
            this.linkCheckins.TabIndex = 51;
            this.linkCheckins.TabStop = true;
            this.linkCheckins.Text = "Fetch Checkins \r\n(Click on a checkin to view it\'s details)";
            this.linkCheckins.UseCompatibleTextRendering = true;
            this.linkCheckins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCheckins_LinkClicked);
            // 
            // FetchCheckinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.linkCheckins);
            this.Controls.Add(this.listBoxCheckins);
            this.Name = "FetchCheckinsForm";
            this.Text = "FetchCheckinsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.LinkLabel linkCheckins;
    }
}