using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OTR.Interface;
namespace OpenMessage
{
    class otr
    {
        public OTRSessionManager otrSess = null;
        public string _uniqueID = null;

        public void createSession(string uid)
        {
            otrSess = new OTRSessionManager(uid);
            otrSess.OnOTREvent += new OTREventHandler(OnEvent);
        }
        public void OnEvent(object source, OTREventArgs e)
        {
            switch (e.GetOTREvent())
            {
                case OTR_EVENT.MESSAGE:

                    break;

                case OTR_EVENT.SEND:

                    break;
                case OTR_EVENT.ERROR:

                    break;
                case OTR_EVENT.READY:

                    break;
                case OTR_EVENT.DEBUG:

                    break;
                case OTR_EVENT.EXTRA_KEY_REQUEST:


                    break;
                case OTR_EVENT.SMP_MESSAGE:

                    break;
                case OTR_EVENT.CLOSED:

                    break;

            }
        }
        private void SendDataOnNetwork(string my_unique_id, string otr_data)
        {
            otrSess.ProcessOTRMessage(my_unique_id, otr_data);
           
        }
    }
}
