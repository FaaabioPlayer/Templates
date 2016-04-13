using System;
using System.ServiceModel.Web;

namespace WcfJsonRestService
{
    public class WcfJsonRestService : IWcfJsonRestService
    {
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "data/{id}")]
        public CorridaExecutada GetData(string id)
        {
            // lookup person with the requested id 
            return new CorridaExecutada()
            {
                Id = Convert.ToInt32(id),
                IdCorridaAgendada = Convert.ToInt32(id) + 1,
                EnderecoOrigemCompleto = "Rua Zuferey, 1228, Vila Progresso",
                EnderecoDestinoCompleto = "Rua Carlos Gomes, 1588, Vila Graff"
            };
        }
    }

    public class CorridaExecutada
    {
        public int Id { get; set; }
        public int IdCorridaAgendada { get; set; }
        public string EnderecoOrigemCompleto { get; set; }
        public string EnderecoDestinoCompleto { get; set; }
    }
}