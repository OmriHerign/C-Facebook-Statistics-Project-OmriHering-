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
    public partial class FormTopResponder : Form
    {
        
        
        private TopResponderFactory m_topResponderFactory;
        
        ITopResponder m_topResponder;


        private void Mount_CheckedChanged(object sender, EventArgs e)
        {
            if (Mount.Checked)
            {
                Year.Enabled = false;
            }
            else
            {
                Year.Enabled = true;
            }
        }


        public FormTopResponder()
        {
            InitializeComponent();          
        }

        

        private void SetTopRespondersOnListBox(string m_period)
        {
            if (m_topResponder.RespondersTable.Count == 0)
            {
                MessageBox.Show("You had no comments or like in the last " + m_period);
            }
            else
            {
                listOfResponder.Items.Clear();
                foreach (Responder responder in m_topResponder.RespondersTable)
                {
                    listOfResponder.Items.Add(responder);

                }
            }
        }

        private void listOfResponder_SelectedIndexChanged(object sender, EventArgs e)
        {
           Responder Spesifcresponder =  listOfResponder.SelectedItem as Responder;
            FormTopResponderDetails topResponderDetailsForm = new FormTopResponderDetails(Spesifcresponder);
            topResponderDetailsForm.ShowDialog();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            m_topResponder.RespondersTable.Clear();
        }

        private void sortComments_Click(object sender, EventArgs e)
        {
            List<Responder> responderList = m_topResponder.RespondersTable.OrderBy(o => o.NumOfComments).ToList();
           ShowTopResponderSortedOnListaBox(responderList);
        }

        private void sortLikes_Click(object sender, EventArgs e)
        {
            List<Responder> responderList = m_topResponder.RespondersTable.OrderBy(o => o.NumOfLikes).ToList();
            ShowTopResponderSortedOnListaBox(responderList);
        }

        private void ShowTopResponderSortedOnListaBox(List<Responder>  responderList)
        {
            responderList.Reverse();
            listOfResponder.Items.Clear();
            foreach (Responder responder in responderList)
            {
                listOfResponder.Items.Add(responder);
            }
        }

        private void i_Choose_Click(object sender, EventArgs e)
        {
            m_topResponderFactory = new TopResponderFactory();
            if (Mount.Checked)
            {
                m_topResponder = m_topResponderFactory.getTopResponder(1);
            }
            else
            {
                m_topResponder = m_topResponderFactory.getTopResponder(2);
            }
            m_topResponder.FillAndSortRespondersTable();
            SetTopRespondersOnListBox(m_topResponder.period);
            Year.Enabled = true;
            Mount.Enabled = true;
        }

        private void Year_CheckedChanged(object sender, EventArgs e)
        {
            if (Year.Checked)
            {
                Mount.Enabled = false;
            }
            else {
                Mount.Enabled = true;
            }
        }
        
    }
}
