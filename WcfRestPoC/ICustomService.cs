using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfRestPoC
{
    [ServiceContract]
    public interface ICustomService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetCustomModels", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<CustomModel> GetCustomModels();

        [OperationContract]
        [WebGet(UriTemplate = "/GetCustomModel/{customModelId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        CustomModel GetCustomModel(string customModelId);
    }
}
