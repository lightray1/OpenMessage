using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using S22.Xmpp;
using S22.Xmpp.Client;
using S22.Xmpp.Core;
using S22.Xmpp.Im;
using System.IO;
using System.Configuration;

namespace OpenMessage
{
    

    public partial class Form1 : Form
    {
        String serverName = "urgero.net"; //Server name of XMPP server.
        String version = "0.0.6N"; //Version String
        Int32 verInt = 001; //Version String as an Integer
        public static string usr = null;
        public Form1()
        {
            InitializeComponent();
            verLabel.Text = version;
            if(DoesSettingExist("usernameSet") == true)
            {
                if(Properties.Settings.Default.usernameSet != "")
                {
                    usernameTxt.Text = Properties.Settings.Default.usernameSet;
                    remember.Checked = true;
                    passwordTxt.Select();
                }
                
            }
            if (DoesSettingExist("TLS") == true)
            {
                if (Properties.Settings.Default.TLS == true)
                {
                    useTLSCheck.Checked = true;
                }

            }
            if(DoesSettingExist("srv") == true)
            {
                if(Properties.Settings.Default.srv != "")
                {
                    serverFQDN.Text = Properties.Settings.Default.srv;
                }
            }

        }
        private bool DoesSettingExist(string settingName)
        {
            return Properties.Settings.Default.Properties.Cast<SettingsProperty>().Any(prop => prop.Name == settingName);
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            startLogin();

        }
        public void startLogin()
        {
            loginBtn.Enabled = false;
            Properties.Settings.Default.srv = serverFQDN.Text;
            Properties.Settings.Default.Save();
            serverName = serverFQDN.Text;
            var client = new XmppClient(serverName, 5222, false);
            try
            {
                client.Error += OnError;

                client.Connect();
            }
            catch (Exception ex)
            {
                msg("Error - Connection", ex.Message);
                //client.Close();
            }
            if (client.Connected == true)
            {
                try
                {
                    client.Authenticate(usernameTxt.Text, passwordTxt.Text);
                }
                catch (System.Security.Authentication.AuthenticationException ex)
                {
                    msg("Error - Authentication", ex.Message);
                    passwordTxt.Text = "";
                }

                if (client.Authenticated == true)
                {
                    usr = usernameTxt.Text;
                    client.Close();
                    Form rosFrm = new roster(usernameTxt.Text, passwordTxt.Text, serverName, useTLSCheck.Checked);
                    rosFrm.Show();
                    this.Hide();
                }
            }
            loginBtn.Enabled = true;
        }
        static void OnError(Object Sender, S22.Xmpp.Core.ErrorEventArgs e)
        {
            //msg("Error - Event", e.Exception.Message);
            
        }
        static void msg(String title, String Error)
        {
            Form newFrm = new newMsgb(title, Error);
            newFrm.ShowDialog();            
        }

        private void remember_CheckedChanged(object sender)
        {
            if (remember.Checked == true)
            {
                Properties.Settings.Default.usernameSet = usernameTxt.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.usernameSet = "";
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                startLogin();
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                startLogin();
            }
        }

        private void useTLSCheck_CheckedChanged(object sender)
        {
            if (useTLSCheck.Checked == true)
            {
                Properties.Settings.Default.TLS = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.TLS = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
