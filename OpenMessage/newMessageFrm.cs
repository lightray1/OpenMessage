﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoFlat;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OpenMessage
{
    public partial class newMessageFrm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);


        public string serverName;
       public String frmId {get; set; }
        String jidFrom;
        public string remoteUID = null;
       public newMessageFrm(string jid,string domain)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            jidFrom = jid;
            newMessageWindow.Text = "Chat with: " + jid;
            serverName = domain;
            this.Text = "Chat with: " + jid;
        }

        public void sendBtn_Click(object sender, EventArgs e)
        {
            roster.client.SendMessage(jidFrom + "@" + serverName, textBox1.Text);
            appendMsg("You: ", textBox1.Text);
            textBox1.Text = "";
            textBox1.Select();

        }
        static void msg(String title, String Error)
        {
            Form newFrm = new newMsgb(title, Error);
            newFrm.ShowDialog();
        }
        public void appendMsg(String jid, String Message)
        {

            if (Message.Contains("/*/*OTR_REQUEST*"))
            {
                //OTR does not work yet, working to get a random session ID first.
                String[] otrMsg = Message.Split('*');
                remoteUID = otrMsg[3];
                //Process the OTR request:
                otr newOtrSess = new otr();
                String SessionID = newOtrSess.generateSessionID();
                //newOtrSess.createSession(SessionID);
                msg("Status - Conversation - New OTR ID", SessionID);
                return; //Do NOT process the rest of this function!!!!
            }
            if(ApplicationIsActivated() == false)
            {
                
            }
            if(jid == "You")
            {
                richTextBox1.SelectionColor = Color.Cyan;
                richTextBox1.AppendText(jid + ": ");
                richTextBox1.SelectionColor = Color.White;
                richTextBox1.AppendText(Message + Environment.NewLine);
            } else
            {
                richTextBox1.SelectionColor = Color.LightGreen;
                richTextBox1.AppendText(jid + ": ");
                richTextBox1.SelectionColor = Color.White;
                richTextBox1.AppendText(Message + Environment.NewLine);
            }
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

        }
        public static bool ApplicationIsActivated()
        {
            var activatedHandle = GetForegroundWindow();
            if (activatedHandle == IntPtr.Zero)
            {
                return false;       // No window is currently activated
            }

            var procId = Process.GetCurrentProcess().Id;
            int activeProcId;
            GetWindowThreadProcessId(activatedHandle, out activeProcId);

            return activeProcId == procId;
        }

        public void _msgText(String jid, String Message)
        {
            appendMsg(jid, Message);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if(textBox1.Text == "") { return; }
                roster.client.SendMessage(jidFrom + "@" + serverName, textBox1.Text);
                appendMsg("You", textBox1.Text);
                textBox1.Text = "";
                textBox1.Select();
            }
        }
    }
}
