using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;


namespace BasicFacebookFeatures
{
    public partial class FormFriendsList : Form
    {
        
        public FormFriendsList()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {

            FillListOfFriends();
            
            base.OnShown(e);            
        }

        private void FillListOfFriends()
        {
            friendList.Items.Clear();
            foreach (User friend in AppData.Instance.Friends)
            {
                friendList.Items.Add(friend);
            }
        }


        private void friendList_SelectedIndexChanged(object sender, EventArgs e)
        {
            friendsPicture.Image = (friendList.SelectedItem as User).ImageNormal;
        }

        private void viewProfile_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.ShowDialog();
        }

        
    }
}
