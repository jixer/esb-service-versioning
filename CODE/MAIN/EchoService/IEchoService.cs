using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EchoService
{
    [ServiceContract(Namespace = "urn:demosvc.chris.net:echo:v0")]
    public interface IEchoService
    {
        [OperationContract]
        string Echo(string value);

        [OperationContract(IsOneWay=false)]
        void NoEcho(string value);        
    }

    [ServiceContract(Namespace = "urn:demosvc.chris.net:echo:v1")]
    public interface IEchoService_V1
    {
        [OperationContract(Action = "urn:demosvc.chris.net:echo:v1/Echo")]
        string Echo(string value);

        [OperationContract(IsOneWay = false)]
        void NoEcho(string value);        
    }

    [ServiceContract(Namespace = "urn:demosvc.chris.net:echo:v2")]
    public interface IEchoService_V2
    {
        [OperationContract(Action = "urn:demosvc.chris.net:echo:v2/Echo")]
        string Echo(string value);

        [OperationContract(IsOneWay = false)]
        void NoEcho(string value);        
    }
}