using MultiTools;
using System;
using System.Windows.Forms;

namespace WebhooksManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebhookURL.Enabled = false;
            name.Enabled = false;
            Avatar.Enabled = false;
            Message.Enabled = false;
        }

        private void nsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nsComboBox1.SelectedIndex == 0)
            {
                //Infos
                WebhookURL.Enabled = true;
                name.Enabled = false;
                Avatar.Enabled = false;
                Message.Enabled = false;
            }
            if (nsComboBox1.SelectedIndex == 1)
            {
                //Send
                WebhookURL.Enabled = true;
                name.Enabled = true;
                Avatar.Enabled = true;
                Message.Enabled = true;
            }
            if (nsComboBox1.SelectedIndex == 2)
            {
                //Edit
                WebhookURL.Enabled = true;
                name.Enabled = true;
                Avatar.Enabled = true;
                Message.Enabled = false;
            }
            if (nsComboBox1.SelectedIndex == 3)
            {
                //Delete
                WebhookURL.Enabled = true;
                name.Enabled = false;
                Avatar.Enabled = false;
                Message.Enabled = false;
            }
        }

        private void nyX_Button1_Click(object sender, EventArgs e)
        {
            if (nsComboBox1.SelectedIndex == 0)
            {
                //Infos
                DiscordClass.infosWebhook(WebhookURL.Text);
            }
            if (nsComboBox1.SelectedIndex == 1)
            {
                //Send
                DiscordClass.sendWebhook(WebhookURL.Text, name.Text, Avatar.Text, Message.Text);
            }
            if (nsComboBox1.SelectedIndex == 2)
            {
                //Edit
                DiscordClass.editWebhook(WebhookURL.Text, name.Text, Avatar.Text);
            }
            if (nsComboBox1.SelectedIndex == 3)
            {
                //Delete
                DiscordClass.removeWebhook(WebhookURL.Text);
            }
        }
    }
}
