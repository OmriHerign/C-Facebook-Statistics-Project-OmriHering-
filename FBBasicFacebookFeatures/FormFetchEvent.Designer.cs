namespace BasicFacebookFeatures
{
    partial class FormFetchEvent
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
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DisplayMember = "name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(26, 48);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(312, 173);
            this.listBoxEvents.TabIndex = 41;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(364, 48);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(160, 173);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEvent.TabIndex = 43;
            this.pictureBoxEvent.TabStop = false;
           // this.pictureBoxEvent.Click += new System.EventHandler(this.pictureBoxEvent_Click);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.labelEvents.Location = new System.Drawing.Point(126, 9);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(190, 30);
            this.labelEvents.TabIndex = 49;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
            this.labelEvents.UseCompatibleTextRendering = true;
            this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            // 
            // FetchEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 262);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.listBoxEvents);
            this.Name = "FetchEventForm";
            this.Text = "FetchEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.LinkLabel labelEvents;
    }
}