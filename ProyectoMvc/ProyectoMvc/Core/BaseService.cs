using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ProyectoMvc.Core
{
    public class BaseService
    {
 
        public EjemploWS.EjemploSoapClient ObtenerEjemploWS()
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(ApplicationSettings.URLEjemploWS));
            var WsSoapClient = new EjemploWS.EjemploSoapClient(binding, endpoint);
            return WsSoapClient;
        }


    }
}
