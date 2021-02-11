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

        public static T GetValue<T>(object value, IFormatProvider provider = null)
        {
            Type type = typeof(T);
            //GetUnderlyingType testa se type permite nulo, caso não permita ele retorna null
            if (Nullable.GetUnderlyingType(type) != null)
                type = Nullable.GetUnderlyingType(type);

            if (value == null || value == DBNull.Value || value.ToString() == "")
                return default(T);

            try
            {
                if (provider != null)
                    return (T)Convert.ChangeType(value, type, provider);
                else
                    return (T)Convert.ChangeType(value, type);
            }
            catch
            {
                return default(T);
            }
        }

        public static short CalculaIdade(DateTime datNascimento)
        {
            short idade = Convert.ToInt16((DateTime.Today - datNascimento).TotalDays / 365.2425);
            return idade;
        }
    }
}
