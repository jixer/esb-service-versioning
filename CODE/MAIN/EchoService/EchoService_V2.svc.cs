using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EchoService
{
    public class EchoService_V2 : IEchoService_V2
    {
        public string Echo(string value)
        {
            return "V2: " + value;
        }


        public void NoEcho(string value)
        {
            return;
        }
    }
}
