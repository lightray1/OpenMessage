using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NATUPNPLib;
using System.Windows.Forms;

namespace OpenMessage
{
    class videoChat
    {
        public string setupPort(string ipAddress, int port, String proto)
        {
           UPnPNATClass upnp = new UPnPNATClass();
            IStaticPortMappingCollection maps = upnp.StaticPortMappingCollection;
            foreach(IStaticPortMapping portMaps in maps)
            {
                
                String IntIP = portMaps.InternalClient;
                int IntPort = portMaps.InternalPort;
                String intProto = portMaps.Protocol;
                if(IntPort == port)
                {
                    maps.Remove(port, intProto);
                    break;
                }
            }

            try
            {
                maps.Add(port, proto, port, ipAddress, true, "Local Open Message Client");
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }
        

    }
}
