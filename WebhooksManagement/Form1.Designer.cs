namespace WebhooksManagement
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nyX_Theme1 = new CS_ClassLibraryTester.NYX_Theme();
            this.Avatar = new CS_ClassLibraryTester.CrystalClearTextBox();
            this.WebhookURL = new CS_ClassLibraryTester.CrystalClearTextBox();
            this.Message = new CS_ClassLibraryTester.CrystalClearTextBox();
            this.name = new CS_ClassLibraryTester.CrystalClearTextBox();
            this.nyX_Button1 = new CS_ClassLibraryTester.NYX_Button();
            this.nsComboBox1 = new NSComboBox();
            this.nsControlButton1 = new NSControlButton();
            this.nsControlButton2 = new NSControlButton();
            this.nyX_Theme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nyX_Theme1
            // 
            this.nyX_Theme1.Animated = true;
            this.nyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nyX_Theme1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Theme1.Controls.Add(this.nsControlButton2);
            this.nyX_Theme1.Controls.Add(this.nsControlButton1);
            this.nyX_Theme1.Controls.Add(this.Avatar);
            this.nyX_Theme1.Controls.Add(this.WebhookURL);
            this.nyX_Theme1.Controls.Add(this.Message);
            this.nyX_Theme1.Controls.Add(this.name);
            this.nyX_Theme1.Controls.Add(this.nyX_Button1);
            this.nyX_Theme1.Controls.Add(this.nsComboBox1);
            this.nyX_Theme1.Customization = "";
            this.nyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nyX_Theme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyX_Theme1.Image = null;
            this.nyX_Theme1.Location = new System.Drawing.Point(0, 0);
            this.nyX_Theme1.Movable = true;
            this.nyX_Theme1.Name = "nyX_Theme1";
            this.nyX_Theme1.NoRounding = false;
            this.nyX_Theme1.Sizable = true;
            this.nyX_Theme1.Size = new System.Drawing.Size(477, 256);
            this.nyX_Theme1.SmartBounds = true;
            this.nyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nyX_Theme1.TabIndex = 0;
            this.nyX_Theme1.Text = "Discord Webhook Mangement";
            this.nyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nyX_Theme1.Transparent = false;
            // 
            // Avatar
            // 
            this.Avatar.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.Avatar.Customization = "";
            this.Avatar.Font = new System.Drawing.Font("Verdana", 8F);
            this.Avatar.Image = null;
            this.Avatar.Location = new System.Drawing.Point(12, 130);
            this.Avatar.MaxLength = 32767;
            this.Avatar.Multiline = false;
            this.Avatar.Name = "Avatar";
            this.Avatar.NoRounding = false;
            this.Avatar.ReadOnly = false;
            this.Avatar.Size = new System.Drawing.Size(453, 24);
            this.Avatar.TabIndex = 5;
            this.Avatar.Text = "Avatar";
            this.Avatar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Avatar.Transparent = false;
            this.Avatar.UseSystemPasswordChar = false;
            // 
            // WebhookURL
            // 
            this.WebhookURL.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.WebhookURL.Customization = "";
            this.WebhookURL.Font = new System.Drawing.Font("Verdana", 8F);
            this.WebhookURL.Image = null;
            this.WebhookURL.Location = new System.Drawing.Point(12, 58);
            this.WebhookURL.MaxLength = 32767;
            this.WebhookURL.Multiline = false;
            this.WebhookURL.Name = "WebhookURL";
            this.WebhookURL.NoRounding = false;
            this.WebhookURL.ReadOnly = false;
            this.WebhookURL.Size = new System.Drawing.Size(453, 24);
            this.WebhookURL.TabIndex = 4;
            this.WebhookURL.Text = "Webhook URL";
            this.WebhookURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WebhookURL.Transparent = false;
            this.WebhookURL.UseSystemPasswordChar = false;
            // 
            // Message
            // 
            this.Message.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.Message.Customization = "";
            this.Message.Font = new System.Drawing.Font("Verdana", 8F);
            this.Message.Image = null;
            this.Message.Location = new System.Drawing.Point(12, 160);
            this.Message.MaxLength = 32767;
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.NoRounding = false;
            this.Message.ReadOnly = false;
            this.Message.Size = new System.Drawing.Size(453, 36);
            this.Message.TabIndex = 3;
            this.Message.Text = "Message";
            this.Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Message.Transparent = false;
            this.Message.UseSystemPasswordChar = false;
            // 
            // name
            // 
            this.name.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.name.Customization = "";
            this.name.Font = new System.Drawing.Font("Verdana", 8F);
            this.name.Image = null;
            this.name.Location = new System.Drawing.Point(12, 100);
            this.name.MaxLength = 32767;
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.NoRounding = false;
            this.name.ReadOnly = false;
            this.name.Size = new System.Drawing.Size(453, 24);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Transparent = false;
            this.name.UseSystemPasswordChar = false;
            // 
            // nyX_Button1
            // 
            this.nyX_Button1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nyX_Button1.Customization = "";
            this.nyX_Button1.Font = new System.Drawing.Font("Arial", 8F);
            this.nyX_Button1.Image = null;
            this.nyX_Button1.Location = new System.Drawing.Point(12, 212);
            this.nyX_Button1.Name = "nyX_Button1";
            this.nyX_Button1.NoRounding = false;
            this.nyX_Button1.Size = new System.Drawing.Size(453, 25);
            this.nyX_Button1.TabIndex = 1;
            this.nyX_Button1.Text = "Just Go!?";
            this.nyX_Button1.Transparent = false;
            this.nyX_Button1.Click += new System.EventHandler(this.nyX_Button1_Click);
            // 
            // nsComboBox1
            // 
            this.nsComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nsComboBox1.ForeColor = System.Drawing.Color.White;
            this.nsComboBox1.FormattingEnabled = true;
            this.nsComboBox1.Items.AddRange(new object[] {
            "Infos",
            "Send",
            "Edit",
            "Delete"});
            this.nsComboBox1.Location = new System.Drawing.Point(12, 31);
            this.nsComboBox1.Name = "nsComboBox1";
            this.nsComboBox1.Size = new System.Drawing.Size(453, 21);
            this.nsComboBox1.TabIndex = 0;
            this.nsComboBox1.SelectedIndexChanged += new System.EventHandler(this.nsComboBox1_SelectedIndexChanged);
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(450, 3);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 6;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // nsControlButton2
            // 
            this.nsControlButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.nsControlButton2.ControlButton = NSControlButton.Button.Minimize;
            this.nsControlButton2.Location = new System.Drawing.Point(431, 3);
            this.nsControlButton2.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton2.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.Name = "nsControlButton2";
            this.nsControlButton2.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton2.TabIndex = 7;
            this.nsControlButton2.Text = "nsControlButton2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 256);
            this.Controls.Add(this.nyX_Theme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nyX_Theme1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme nyX_Theme1;
        private NSComboBox nsComboBox1;
        private CS_ClassLibraryTester.CrystalClearTextBox Message;
        private CS_ClassLibraryTester.CrystalClearTextBox name;
        private CS_ClassLibraryTester.NYX_Button nyX_Button1;
        private CS_ClassLibraryTester.CrystalClearTextBox WebhookURL;
        private CS_ClassLibraryTester.CrystalClearTextBox Avatar;
        private NSControlButton nsControlButton2;
        private NSControlButton nsControlButton1;
    }
}

