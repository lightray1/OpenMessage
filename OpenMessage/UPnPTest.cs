using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace OpenMessage
{
    public partial class UPnPTest : Form
    {
        TcpListener server = null;
        public UPnPTest()
        {
            InitializeComponent();
        }

        private void UPnPTest_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            OpenMessage.videoChat vc = new OpenMessage.videoChat();
            String setup = vc.setupPort(vc.getInternalIP(), 6565, "TCP");
            if (setup == "true")
            {
                backgroundWorker1.RunWorkerAsync();
                
            } else
            {
                MessageBox.Show(setup);
            }
        }
        public void tryServer()
        {
            OpenMessage.videoChat vc = new OpenMessage.videoChat();
            try
            {
                Int32 port = 6565;
                IPAddress localAddr = IPAddress.Parse(vc.getInternalIP());

                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop. 
                while (true)
                {
                    label1.Text = "Running temp server on " + vc.getInternalIP() + ":6565";
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests. 
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Hello!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client. 
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", data);
                    }

                    // Shutdown and end connection
                    client.Close();
                    vc.destroyPort(6565, "TCP");
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            tryServer();
        }
    }
}
