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
    public partial class FormCheckInByFriends : Form
    {

        
        public FormCheckInByFriends()
        {
            InitializeComponent();
        }

        private void friendsBoton_Click(object sender, EventArgs e)
        {
            fetchMyFriends();
        }

        private void fetchMyFriends()
        {
            try
            {

                listOfFriends.DisplayMember = "Name";
                foreach (User friend in AppData.Instance.Friends)
                {
                    listOfFriends.Items.Add(friend);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You are not logged in");
            }
        }

        private void listOfFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (listOfFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listOfFriends.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
                }
            }
        }

        private void clearFriends_Click(object sender, EventArgs e)
        {
            listOfFriends.Items.Clear();
        }

        private void CheckinButton_Click(object sender, EventArgs e)
        {
            fechFriendsCheckins();
        }

        private void fechFriendsCheckins()
        {

            User selectedFriend = listOfFriends.SelectedItem as User;
            try
            {
                listOfCheckins.DisplayMember = "Name";
                foreach (Checkin checkin in selectedFriend.Checkins)
                {
                    listOfCheckins.Items.Add(checkin.Place);
                    listCheckinsDate.Items.Add(checkin.CreatedTime);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select friend");
            }
        }

        private void clearCheckins_Click(object sender, EventArgs e)
        {
            listOfCheckins.Items.Clear();
            listCheckinsDate.Items.Clear();
        
        }

        private void buttonWeb_Click(object sender, EventArgs e)
        {
            try
            {

                Place place = listOfCheckins.SelectedItem as Place;
                System.Diagnostics.Process.Start("http://google.com/search?q=" + place.Name);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Select Place");
            }

        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            FavoriteCheckIn();
        }

        private void FavoriteCheckIn()
        {

            List<string> placeList = new List<string>();
            foreach (User friend in AppData.Instance.Friends)
            {
                foreach (Checkin checkin in friend.Checkins)
                {
                    placeList.Add(checkin.Place.Name);
                }
            }

            Dictionary<string, int> sorted = new Dictionary<string, int>();
            foreach (string place in placeList)
            {
                if (sorted.ContainsKey(place))
                {
                    sorted[place] += 1;
                }
                else
                {
                    sorted.Add(place, 1);
                }
            }


            int big = 0;
            string bestPlace = "";
            foreach (string key in sorted.Keys)
            {
                if (sorted[key] > big)
                {
                    big = sorted[key];
                    bestPlace = key;
                }
            }

            MessageBox.Show("The Most famomous place is " + bestPlace);

        }




    }
}
