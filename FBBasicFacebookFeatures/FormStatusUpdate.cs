using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormStatusUpdate : Form
    {
        public FormStatusUpdate()
        {
            InitializeComponent();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            AppData.Instance.LoggedInUser.PostStatus(textBoxStatus.Text);
            textBoxStatus.Text = string.Empty;
            MessageBox.Show("Post Succeeded!", "Post success", MessageBoxButtons.OK);
        
        }
    }
}
