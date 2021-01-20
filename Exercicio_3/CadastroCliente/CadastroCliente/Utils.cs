using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CadastroCliente.Classes;

namespace CadastroCliente
{
    public class Utils
    {
        public static CEP GetCep(string CEP)
        {
            string action = string.Format("https://viacep.com.br/ws/{0}/json", CEP);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;
            string json = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new Exception("CEP informado no formato inválido!");
            }

            if (JObject.Parse(json).ContainsKey("erro"))
            {
                throw new Exception("CEP não encontrado!");
            }

            CEP cep = JsonConvert.DeserializeObject<CEP>(json);

            return cep;
        }
    }
}
