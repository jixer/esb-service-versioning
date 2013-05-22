using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EchoService
{
    public class EchoService_V1 : IEchoService_V1
    {        
        public string Echo(string value)
        {
            return "V1: " + value;
        }


        public void NoEcho(string value)
        {
            return;
        }
    }
}
