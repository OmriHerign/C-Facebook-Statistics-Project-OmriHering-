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

namespace BasicFacebookFeatures.WithSingltonAppSettings
{
    public partial class checkInByFriends : Form
    {

        
        public checkInByFriends()
        {
            InitializeComponent();
        }

        private void loginAndInit()
        {

            try
            {
                profilePictureOfUser.Image = AppData.Instance.LoggedInUser.ImageNormal;
                UserProfile.Text = AppData.Instance.LoggedInUser.FirstName + " " + AppData.Instance.LoggedInUser.LastName;
            }
            catch (Exception loginFailed)
            {
                MessageBox.Show(loginFailed.Message, "Login Failed!", MessageBoxButtons.OK);
            }           

        }


        protected override void OnShown(EventArgs e)
        {
            try
            {
                profilePictureOfUser.Image = AppData.Instance.LoggedInUser.ImageNormal;
                UserProfile.Text = AppData.Instance.LoggedInUser.FirstName + " " + AppData.Instance.LoggedInUser.LastName;
                fillNewsFeedListBox();
            }
            catch (Exception loginFailed)
            {
                MessageBox.Show(loginFailed.Message, "Login Failed!", MessageBoxButtons.OK);
            }

            base.OnShown(e);
        }        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            FormStatusUpdate statusUpdateForm = new FormStatusUpdate();
            statusUpdateForm.ShowDialog();
        }
        
        private void friendsListButton_Click(object sender, EventArgs e)
        {
            FormFriendsList formFriends = new FormFriendsList();
            formFriends.ShowDialog();
        
        }

        private void myProfile_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new FormProfile();
            profileForm.ShowDialog();
        }

        private void newFeed_Click(object sender, EventArgs e)
        {
            FormNewFeed newFeedForm = new FormNewFeed();
            newFeedForm.ShowDialog();
        }

        private void fetchEvent_Click(object sender, EventArgs e)
        {
            FormFetchEvent fetchEventForm = new FormFetchEvent();
            fetchEventForm.ShowDialog();
        }

        private void fetchCheckIn_Click(object sender, EventArgs e)
        {
            FormFetchCheckins fetchCheckInForm = new FormFetchCheckins();
            fetchCheckInForm.ShowDialog();
        }

        private void topResponderButton_Click(object sender, EventArgs e)
        {
            FormTopResponder topResponderForm = new FormTopResponder();
            topResponderForm.ShowDialog();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            FormCheckInByFriends formCheckInByFriends = new FormCheckInByFriends();
            formCheckInByFriends.ShowDialog();
        }

        private void allNewFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((allNewFeed.SelectedItem as PostAdapter).Post.Type == Post.eType.photo)
            {
                pictureBoxSelectedNewsFeedPhoto.LoadAsync((allNewFeed.SelectedItem as PostAdapter).Post.PictureURL);
            }
            if ((allNewFeed.SelectedItem as PostAdapter).Post.Type == Post.eType.video)
            {
                string video = (allNewFeed.SelectedItem as PostAdapter).Post.Message;
                System.Diagnostics.Process.Start(video);

                pictureBoxSelectedNewsFeedPhoto.Image = null;
            }
            else {
                string status = (allNewFeed.SelectedItem as PostAdapter).Post.Message;

                textBoxStatus.Text = status;
            }
        
        }

        private void fillNewsFeedListBox()
        {
            List<PostAdapter> newsFeed = new List<PostAdapter>();

            FacebookService.s_CollectionLimit = 25;

            foreach (Post post in AppData.Instance.LoggedInUser.NewsFeed)
            {
                newsFeed.Add(new PostAdapter(post));
            }

            allNewFeed.Items.Clear();

            foreach (PostAdapter post in newsFeed)
            {
                allNewFeed.Items.Add(post);
            }
        }
}

}
