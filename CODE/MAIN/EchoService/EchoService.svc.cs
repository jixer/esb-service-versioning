using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EchoService
{        
    public class EchoService : IEchoService
    {
        public string Echo(string value)
        {
            return value;
        }


        public void NoEcho(string value)
        {
            return;
        }
    }
}
