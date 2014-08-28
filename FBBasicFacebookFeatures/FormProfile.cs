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
    public partial class FormProfile : Form
    {
        private User m_User;

        public FormProfile()
        {
            m_User = AppData.Instance.LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {

            firstName.Text = m_User.FirstName;
            lastName.Text = m_User.LastName;
            birthday.Text = m_User.Birthday;
            sex.Text = m_User.Gender.ToString();
            userPicture.Image = m_User.ImageNormal;
            base.OnShown(e);
        }
    }
}
