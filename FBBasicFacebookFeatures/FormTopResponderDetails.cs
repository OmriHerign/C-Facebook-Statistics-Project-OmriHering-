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
    public partial class FormTopResponderDetails : Form
    {
        private Responder m_Responder;

        public FormTopResponderDetails(Responder l_Responder)
        {
           m_Responder = l_Responder;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            pictureOfResponder.Image = m_Responder.ResponderUser.ImageNormal;
            numOfComments.Text = m_Responder.NumOfComments.ToString();
            numOfLikes.Text = m_Responder.NumOfLikes.ToString();
        
            base.OnShown(e);
        }

    }
}
