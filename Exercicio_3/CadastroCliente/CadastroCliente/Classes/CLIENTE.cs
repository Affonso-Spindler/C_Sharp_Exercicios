using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Classes
{
    public class CLIENTE
    {
        public int? Codcliente { get; set; }
        public string Nomcliente { get; set; }
        public string Email { get; set; }
        public short Indtipopessoa { get; set; }
        public string Cpfcnpj { get; set; }
        public string Ddd1 { get; set; }
        public string Telefone1 { get; set; }
        public string Ddd2 { get; set; }
        public string Telefone2 { get; set; }
        public DateTime Datnascimento { get; set; }
        public short Idade { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Localidade { get; set; }
        public string Complemento { get; set; }
        public string Uf { get; set; }
    }
}
