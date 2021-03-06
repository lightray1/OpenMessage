﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NATUPNPLib;
using System.Windows.Forms;
using System.Net;

namespace OpenMessage
{
    class videoChat
    {
        public string getInternalIP()
        {
            string host = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostEntry(host);
            return ip.AddressList[0].ToString();
        }
        public string setupPort(string ipAddress, int port, String proto)
        {
            try
            {
                UPnPNAT upnp = new UPnPNAT();
            IStaticPortMappingCollection maps = upnp.StaticPortMappingCollection;
            //foreach(IStaticPortMapping portMaps in maps)
            //{
                
            //    String IntIP = portMaps.InternalClient;
            //    int IntPort = portMaps.InternalPort;
            //    String intProto = portMaps.Protocol;
            //    if(IntPort == port)
            //    {
            //        port += 1;
            //    }
            //}

            
                maps.Add(port, proto, port, ipAddress, true, "Local Open Message Client");
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }
        public bool destroyPort(int port, String proto)
        {
            UPnPNATClass upnp = new UPnPNATClass();
            IStaticPortMappingCollection maps = upnp.StaticPortMappingCollection;
            try
            {
                maps.Remove(port, proto);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        

    }
}
