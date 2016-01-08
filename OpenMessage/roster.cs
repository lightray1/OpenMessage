﻿using System;
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
namespace OpenMessage
{
    public partial class roster : Form
    {
        public String serverName; //Server name of XMPP server.
        public bool isHide = false; //Show notification icon or not...
        public static XmppClient client = new XmppClient("example.com", 5222, false, null);
        public ImageList avatarList = new ImageList();
        public Roster rs;
        public roster(String username, String password, string domain, bool useTLS)
        {
            InitializeComponent();
            try
            {
                serverName = domain;
                friendView.Columns.Add("Avatar", 100);
                friendView.Columns.Add("Username", 100);
                if(useTLS == true)
                {
                    if(client.Connected == true)
                    {
                        client.Close();
                    }
                    client = new XmppClient(serverName, 5222, true, null);
                    client.Error += OnError;
                    client.Message += OnNewMessage;
                    client.RosterUpdated += OnRosterUpdate;
                    client.Connect();

                } else
                {
                    if (client.Connected == true)
                    {
                        client.Close();
                    }
                    client = new XmppClient(serverName, 5222, false, null);
                    client.Error += OnError;
                    client.Message += OnNewMessage;
                    client.RosterUpdated += OnRosterUpdate;
                    client.Connect();
                }
                
                
            }
            catch (Exception ex)
            {
                msg("Error - Connection - RosterForm", ex.ToString());
                
            }
            try
            {
                if (client.Connected == true)
                {
                    try
                    {
                        client.Authenticate(username, password);
                    }
                    catch (System.Security.Authentication.AuthenticationException ex)
                    {
                        //This shouldn't happen but just to text...
                        msg("Error - Authentication - RosterForm", ex.ToString());

                    }

                    if (client.Authenticated == true)
                    {
                        //Set Username label to show we are logged in...
                        usernameLabel.Text = username;
                        //Grab roster...
                        foreach(var item in client.GetRoster())
                        {
                            String resID = item.Jid.Resource;
                            String domain2 = item.Jid.Domain;
                            String jid = item.Jid.ToString();
                            if(resID != null) { jid.Replace(resID, ""); jid = jid.Replace("@/", ""); }
                            if (jid.Contains("@")) { jid = jid.Replace("@", ""); }
                            jid = jid.Replace(domain2, "");
                            
                            friendView.Items.Add(jid, 0);
                        }
                        Status online = new Status(Availability.Online);
                        client.SetStatus(online);
                    }
                }
            }
            catch(Exception ex)
            {
                msg("Error - Auth - RosterForm", ex.ToString());
            }
            if(client.IsEncrypted == true)
            {
                monoFlat_ThemeContainer1.Text = "OpenMessage IM (TLS)";
            }
            friendView.SmallImageList = avatarList;
            friendView.LargeImageList = avatarList;
            
            //Set Avatar...
            avatarList.Images.Add(Properties.Resources.User);
            //friendView.Items.Add(new ListViewItem(usernameLabel.Text + "(You)", 0));
        }
        private void OnRosterUpdate(Object sender, S22.Xmpp.Im.RosterUpdatedEventArgs e)
        {
            if(e.Removed == true)
            {
                
                RosterItemsList(e.Item.Name, false);
            } else
            {
                RosterItemsList(e.Item.Name, true);
            }
        }
        private void RosterItemsList(String itemName, Boolean adding)
        {
            
            if(adding == false)
            {
                
                try
                {
                    
                }
                catch(Exception ex)
                {
                    msg("Error - RemoveName - RosterForm", ex.ToString());
                }
            } else
            {

                //friendView.Items.Add(new ListViewItem(itemName, 0));
            }
        }
        public void _setNotice(string message)
        {
            //Nothing yet, but soon.
        }
        static void OnNewMessage(object sender, S22.Xmpp.Im.MessageEventArgs e)
        {
            String resID = e.Jid.Resource;
            String domain = e.Jid.Domain;
            String jid = e.Jid.ToString().Replace(resID, "");
            jid = jid.Replace(domain, "");
            jid = jid.Replace("@/", "");
            String mes = e.Message.Body;
            if (CheckIfFormIsOpen(jid, mes) == true){

            } else
            {
                var invokingForm = Application.OpenForms[0]; // or whatever Form you can access
                if (invokingForm.InvokeRequired)
                {
                    invokingForm.BeginInvoke(new EventHandler<S22.Xmpp.Im.MessageEventArgs>(OnNewMessage), sender, e);
                    return; // important!!!
                }
                newMessageFrm tempMsg = new newMessageFrm(jid, domain);

                tempMsg._msgText(jid, mes);
                tempMsg.frmId = jid;
                tempMsg.Show();
            }
            
            
        }
        static bool CheckIfFormIsOpen(string id, string message)
        {

            FormCollection fc = Application.OpenForms;
            foreach (newMessageFrm frm in fc.OfType<newMessageFrm>())
            {
                if (frm.frmId == id)
                {
                    frm._msgText(id, message);
                    return true;
                }
            }
            return false;
        }

        static void OnError(Object Sender, S22.Xmpp.Core.ErrorEventArgs e)
        {
            if (e.Exception.Message.Contains("The server has closed the XML"))
            {

            } else if(e.Exception.Message.Contains("Unexpected node"))
            {

            } else
            {
                msg("Error - Event - RosterForm", e.Exception.Message + ":" + e.Exception.ToString());
            }
            
        }
        static void msg(String title, String Error)
        {
            Form newFrm = new newMsgb(title, Error);
            newFrm.ShowDialog();
        }

        private void roster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isHide == true)
            {
                e.Cancel = true;
                notifyIcon1.BalloonTipTitle = "OpenMessage";
                notifyIcon1.BalloonTipText = "Still logged in...";
                notifyIcon1.Visible = true;
                Hide();
            }
            Application.Exit();
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(client.Connected == false)
            {
                usernameLabel.ForeColor = Color.Red;
            } else
            {
                if(client.Authenticated == true)
                {
                    usernameLabel.ForeColor = Color.Green;

                } else
                {
                    usernameLabel.ForeColor = Color.Yellow;
                }
                
            }
        }
        public void sendMessageTo(String jid, String message)
        {
            client.SendMessage(jid, message);
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            isHide = false;
            try
            {
                Status offline = new Status(Availability.Offline);
                client.SetStatus(offline);
                client.Close();
            }
            catch (Exception ex)
            {
                //Connection is closed already no need to do anything...
            }
            isHide = false;
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            isHide = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            isHide = true;
            notifyIcon1.BalloonTipTitle = "OpenMessage";
            notifyIcon1.BalloonTipText = "Still logged in...";
            
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(2000);
            Hide();
        }

        private void openWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            isHide = false;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isHide = false;
            notifyIcon1.Visible = false;
            //Status offline = new Status(Availability.Offline);
            //client.SetStatus(offline);
            client.Close();
            Application.Exit();
        }

        private void friendView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void friendView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItem = friendView.SelectedItems;
            ListViewItem lsItem = selectedItem[0];
            String item = lsItem.Text;
                if(CheckIfFormIsOpen(item, "") == true)
            {

            }
            else
            {
                newMessageFrm tempMsg = new newMessageFrm(item, serverName);
                tempMsg.frmId = item;
                tempMsg.Show();
            }
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            if(client.Connected == false)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msg("Sorry!", "Almost there.... Just a little further....");
        }
    }
}
