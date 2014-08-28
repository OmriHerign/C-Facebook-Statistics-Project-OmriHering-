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
    public partial class FormFetchCheckins : Form
    {
        
        public FormFetchCheckins()
        {
            InitializeComponent();
        }

       
        private void linkCheckins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchCheckins();
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in AppData.Instance.LoggedInUser.Checkins)
            {
                listBoxCheckins.Items.Add(checkin);
            }
        }

        
 
        }

    }

