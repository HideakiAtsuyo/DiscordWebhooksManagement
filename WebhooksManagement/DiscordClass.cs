using Leaf.xNet;
using System;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
using System.Diagnostics;

namespace MultiTools
{
    class DiscordClass
    {
        //////////////////////////////////WEBHOOKS//////////////////////////////////
        public static void infosWebhook(dynamic webhook)
        {
            try
            {
                MessageBox.Show("Too lazyyyyyy", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(webhook);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: \n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static byte[] Post(dynamic URI, NameValueCollection Value) { using (WebClient WebClient = new WebClient()) return WebClient.UploadValues(URI, Value); }
        public static void sendWebhook(dynamic URL, dynamic Username, dynamic Avatar, dynamic Message)
        {
            try
            {
                Post(URL, new NameValueCollection() { { "username", Username }, { "content", Message }, { "avatar_url", Avatar } });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: \n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void editWebhook(dynamic webhook, dynamic name, dynamic avatar)
        {
            try
            {
                using (HttpRequest request = new HttpRequest())
                {
                    /*
                    RequestParams payload = new RequestParams();
                    payload["name"] = name;
                    payload["avatar"] = avatar;
                    string data = request.Patch(webhook, payload).ToString();
                    */
                    MessageBox.Show("Later", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: \n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void removeWebhook(dynamic webhook)
        {
            try
            {
                using (HttpRequest request = new HttpRequest())
                {
                    request.UseCookies = false;
                    request.Delete(webhook).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: \n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //////////////////////////////////ReportDiscord//////////////////////////////////
    }
}
