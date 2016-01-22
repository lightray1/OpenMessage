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
    public partial class AddFriend : Form
    {
        public AddFriend()
        {
            InitializeComponent();
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            String server = Properties.Settings.Default.srv;
            String username = friendName.Text;
            S22.Xmpp.Jid tempName = new S22.Xmpp.Jid(username + "@" + server);
            try
            {
                roster.client.AddContact(tempName);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            this.Close();

        }
    }
}
