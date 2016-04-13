using System.ServiceModel;

namespace WcfJsonRestService
{
    [ServiceContract]
    public interface IWcfJsonRestService
    {
        [OperationContract]
        CorridaExecutada GetData(string id);
    }
}