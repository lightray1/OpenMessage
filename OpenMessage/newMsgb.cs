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
    public partial class newMsgb : Form
    {
        
        public newMsgb(String title, String MsgText)
        {
            InitializeComponent();
            message.Text = MsgText;
            messageFrm.Text = title;

        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messageFrm_Click(object sender, EventArgs e)
        {

        }
    }
}
