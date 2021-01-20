using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    public class HttpInstance
    {
        private static HttpClient httpClienteInstance;

        private HttpInstance()
        {

        }

        public static HttpClient GetHttpClientInstance()
        {
            if (httpClienteInstance == null)
            {
                httpClienteInstance = new HttpClient();
                httpClienteInstance.DefaultRequestHeaders.ConnectionClose = false;
            }
            return httpClienteInstance;
        }
    }
}
