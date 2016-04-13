using System.ServiceModel;

namespace WcfJsonRestService
{
    [ServiceContract]
    public interface IWcfJsonRestService
    {
        [OperationContract]
        Person GetData(string id);
    }
}