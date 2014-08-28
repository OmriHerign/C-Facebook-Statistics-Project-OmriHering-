namespace BasicFacebookFeatures
{
    partial class FormTopResponder
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
            this.listOfResponder = new System.Windows.Forms.ListBox();
            this.sortComments = new System.Windows.Forms.Button();
            this.sortLikes = new System.Windows.Forms.Button();
            this.Mount = new System.Windows.Forms.CheckBox();
            this.Year = new System.Windows.Forms.CheckBox();
            this.i_Choose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfResponder
            // 
            this.listOfResponder.FormattingEnabled = true;
            this.listOfResponder.Location = new System.Drawing.Point(32, 67);
            this.listOfResponder.Name = "listOfResponder";
            this.listOfResponder.Size = new System.Drawing.Size(219, 355);
            this.listOfResponder.TabIndex = 1;
            this.listOfResponder.SelectedIndexChanged += new System.EventHandler(this.listOfResponder_SelectedIndexChanged);
            // 
            // sortComments
            // 
            this.sortComments.Location = new System.Drawing.Point(444, 67);
            this.sortComments.Name = "sortComments";
            this.sortComments.Size = new System.Drawing.Size(154, 23);
            this.sortComments.TabIndex = 2;
            this.sortComments.Text = "Sort by num of comments";
            this.sortComments.UseVisualStyleBackColor = true;
            this.sortComments.Click += new System.EventHandler(this.sortComments_Click);
            // 
            // sortLikes
            // 
            this.sortLikes.Location = new System.Drawing.Point(444, 26);
            this.sortLikes.Name = "sortLikes";
            this.sortLikes.Size = new System.Drawing.Size(154, 23);
            this.sortLikes.TabIndex = 3;
            this.sortLikes.Text = "Sort by num of likes";
            this.sortLikes.UseVisualStyleBackColor = true;
            this.sortLikes.Click += new System.EventHandler(this.sortLikes_Click);
            // 
            // Mount
            // 
            this.Mount.AutoSize = true;
            this.Mount.Location = new System.Drawing.Point(333, 114);
            this.Mount.Name = "Mount";
            this.Mount.Size = new System.Drawing.Size(78, 17);
            this.Mount.TabIndex = 5;
            this.Mount.Text = "This mount";
            this.Mount.UseVisualStyleBackColor = true;
            this.Mount.CheckedChanged += new System.EventHandler(this.Mount_CheckedChanged);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(444, 114);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(69, 17);
            this.Year.TabIndex = 6;
            this.Year.Text = "This year";
            this.Year.UseVisualStyleBackColor = true;
            this.Year.CheckedChanged += new System.EventHandler(this.Year_CheckedChanged);
            // 
            // i_Choose
            // 
            this.i_Choose.Location = new System.Drawing.Point(381, 149);
            this.i_Choose.Name = "i_Choose";
            this.i_Choose.Size = new System.Drawing.Size(75, 23);
            this.i_Choose.TabIndex = 7;
            this.i_Choose.Text = "choose";
            this.i_Choose.UseVisualStyleBackColor = true;
            this.i_Choose.Click += new System.EventHandler(this.i_Choose_Click);
            // 
            // FormTopResponder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 434);
            this.Controls.Add(this.i_Choose);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Mount);
            this.Controls.Add(this.sortLikes);
            this.Controls.Add(this.sortComments);
            this.Controls.Add(this.listOfResponder);
            this.Name = "FormTopResponder";
            this.Text = "TopResponderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfResponder;
        private System.Windows.Forms.Button sortComments;
        private System.Windows.Forms.Button sortLikes;
        private System.Windows.Forms.CheckBox Mount;
        private System.Windows.Forms.CheckBox Year;
        private System.Windows.Forms.Button i_Choose;
    }
}