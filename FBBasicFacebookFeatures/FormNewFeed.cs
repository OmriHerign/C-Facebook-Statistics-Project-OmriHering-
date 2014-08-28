using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormNewFeed : Form
    {
        
        public FormNewFeed()
        {
            InitializeComponent();
        }

        

        private void fetchNewsFeed()
        {
            listBoxNewsFeed.Items.Clear();

            foreach (Post post in AppData.Instance.LoggedInUser.NewsFeed)
            {
                if (post.Message != null)
                {
                    listBoxNewsFeed.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxNewsFeed.Items.Add(post.Caption);
                }
                else
                {
                    listBoxNewsFeed.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
        }

        private void fetchNewFeed_Click(object sender, EventArgs e)
        {
            fetchNewsFeed();
        
        }
    }
}
