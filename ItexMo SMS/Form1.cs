using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Twilio_SMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool IsFormValidated() 
        {
            bool result = true;

            if (txtRecipient.Text == "")
            {
                result = false;
                txtRecipient.Focus();
            }
            else if (txtMessage.Text == "") 
            {
                result = false;
                txtMessage.Focus();
            }

            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            if (this.IsFormValidated()) 
            {
                ItexMoApi msg = new ItexMoApi();

                dynamic result = msg.SendMessage(txtRecipient.Text, txtMessage.Text);

                if (result == "0")
                {
                    MessageBox.Show("Message Sent!", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRecipient.Text= "";
            txtMessage.Text = "";
            txtRecipient.Focus();
        }
    }
}
