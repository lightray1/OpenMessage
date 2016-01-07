using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenMessage
{
    public partial class newMessageFrm : Form
    {

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
        }

        public void sendBtn_Click(object sender, EventArgs e)
        {
            roster.client.SendMessage(jidFrom + "@" + serverName, textBox1.Text);
            appendMsg("You: ", textBox1.Text);
            textBox1.Text = "";
            textBox1.Select();

        }
        public void appendMsg(String jid, String Message)
        {

            if (Message.Contains("/*/*OTR_REQUEST*"))
            {
                String[] otrMsg = Message.Split('*');
                remoteUID = otrMsg[3];
                //Process the OTR request:
                otr newOtrSess = new otr();
                newOtrSess.createSession("");
                return; //Do NOT process the rest of this function!!!!
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
