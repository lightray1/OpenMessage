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
    public partial class appOptions : Form
    {
        public appOptions()
        {
            InitializeComponent();
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName == null || openFileDialog1.FileName == "")
                {

                }
                else
                {
                    notificationSound.Text = openFileDialog1.FileName;
                }

            }
            catch
            {

            }
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.notification = notificationSound.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void appOptions_Load(object sender, EventArgs e)
        {
            notificationSound.Text = Properties.Settings.Default.notification;
        }
    }
}
