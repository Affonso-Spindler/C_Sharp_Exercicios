using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    public static class Validations
    {
        /// <summary>
        /// Informar um CNPJ completo para validação do digito verificador
        /// </summary>
        /// <param name="cnpj">Int64 com o numero CNPJ completo com Digito</param>
        /// <returns>Boolean True/False onde True=Digito CNPJ Valido</returns>
        public static bool ValidaCNPJ(long cnpj)
        {
            return ValidaCNPJ(cnpj.ToString("D14"));
        }

        /// <summary>
        /// Informar um CNPJ completo para validação do digito verificador
        /// </summary>
        /// <param name="cnpj">string com o numero CNPJ completo com Digito</param>
        /// <returns>Boolean True/False onde True=Digito CNPJ Valido</returns>
        public static bool ValidaCNPJ(string cnpj)
        {
            // Declara variaveis para uso
            string new_cnpj = "";

            // Retira carcteres invalidos não numericos da string
            for (int i = 0; i < cnpj.Length; i++)
            {
                if (isDigito(cnpj.Substring(i, 1)))
                {
                    new_cnpj += cnpj.Substring(i, 1);
                }
            }

            // Ajusta o Tamanho do CNPJ para 14 digitos considerando o digito verificador e completando com zeros a esquerda
            new_cnpj = Convert.ToInt64(new_cnpj).ToString("D14");

            // Verifica se o CNPJ informado tem os 14 digitos 
            if (new_cnpj.Length > 14)
            {
                return false;
            }

            // Calcula o digito do CNPJ e compara com o digito informado
            if (CalculaDigCNPJ(new_cnpj.Substring(0, 12)) == new_cnpj.Substring(12, 2))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Calcula o Digito verificador de um CNPJ informado  
        /// </summary>
        /// <param name="cnpj">int64 com o CNPJ contendo 12 digitos e sem o digito verificador</param>
        /// <returns>string com o digito calculado do CNPJ ou null caso o CNPJ informado for maior que 12 digitos</returns>
        public static string CalculaDigCNPJ(long cnpj)
        {
            return CalculaDigCNPJ(cnpj.ToString("D12"));
        }

        /// <summary>
        /// Calcula o Digito verificador de um CNPJ informado  
        /// </summary>
        /// <param name="cnpj">string com o CNPJ contendo 12 digitos e sem o digito verificador</param>
        /// <returns>string com o digito calculado do CNPJ ou null caso o CNPJ informado for maior que 12 digitos</returns>
        public static string CalculaDigCNPJ(string cnpj)
        {
            // Declara variaveis para uso
            string new_cnpj = "";
            string digito = "";
            int[] calculo = new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int Aux1 = 0;
            int Aux2 = 0;

            // Retira carcteres invalidos não numericos da string
            for (int i = 0; i < cnpj.Length; i++)
            {
                if (isDigito(cnpj.Substring(i, 1)))
                {
                    new_cnpj += cnpj.Substring(i, 1);
                }
            }

            // Ajusta o Tamanho do CNPJ para 12 digitos completando com zeros a esquerda
            new_cnpj = Convert.ToInt64(new_cnpj).ToString("D12");

            // Caso o tamanho do CNPJ informado for maior que 12 digitos retorna nulo
            if (new_cnpj.Length > 12)
            {
                return null;
            }

            // Calcula o primeiro digito do CNPJ
            Aux1 = 0;

            for (int i = 0; i < new_cnpj.Length; i++)
            {
                Aux1 += Convert.ToInt32(new_cnpj.Substring(i, 1)) * calculo[i];
            }

            Aux2 = (Aux1 % 11);

            // Carrega o primeiro digito na variavel digito
            if (Aux2 < 2)
            {
                digito += "0";
            }
            else
            {
                digito += (11 - Aux2).ToString();
            }

            // Adiciona o primeiro digito ao final do CNPJ para calculo do segundo digito
            new_cnpj += digito;

            // Calcula o segundo digito do CNPJ
            calculo = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            Aux1 = 0;

            for (int i = 0; i < new_cnpj.Length; i++)
            {
                Aux1 += Convert.ToInt32(new_cnpj.Substring(i, 1)) * calculo[i];
            }

            Aux2 = (Aux1 % 11);

            // Carrega o segundo digito na variavel digito
            if (Aux2 < 2)
            {
                digito += "0";
            }
            else
            {
                digito += (11 - Aux2).ToString();
            }

            return digito;
        }

        /// <summary>
        /// Verifica se um digito informado é um numero
        /// </summary>
        /// <param name="digito">string com um caracter para verificar se é um numero</param>
        /// <returns>Boolean True/False</returns>
        private static bool isDigito(string digito)
        {
            int n;
            return int.TryParse(digito, out n);
        }

        /// <summary>
        /// Informar um CPF completo para validação do digito verificador
        /// </summary>
        /// <param name="cpf">Int64 com o numero CPF completo com Digito</param>
        /// <returns>Boolean True/False onde True=Digito CPF Valido</returns>
        public static Boolean ValidaCPF(long cpf)
        {
            return ValidaCPF(cpf.ToString("D11"));
        }

        /// <summary>
        /// Informar um CPF completo para validação do digito verificador
        /// </summary>
        /// <param name="cpf">string com o numero CPF completo com Digito</param>
        /// <returns>Boolean True/False onde True=Digito CPF Valido</returns>
        public static bool ValidaCPF(string cpf)
        {
            // Declara variaveis para uso
            string new_cpf = "";

            // Retira carcteres invalidos não numericos da string
            for (int i = 0; i < cpf.Length; i++)
            {
                if (isDigito(cpf.Substring(i, 1)))
                {
                    new_cpf += cpf.Substring(i, 1);
                }
            }

            // Ajusta o Tamanho do CPF para 11 digitos considerando o digito verificador e completando com zeros a esquerda
            new_cpf = Convert.ToInt64(new_cpf).ToString("D11");

            // Verifica se o cpf informado tem os 11 digitos 
            if (new_cpf.Length > 11)
            {
                return false;
            }

            //Verifica se todos os digitos são iguais, se sim retorna false

            if (!ValidaDigitosIguais(new_cpf))
            {
                return false;
            }


            // Calcula o digito do CPF e compara com o digito informado
            if (CalculaDigCPF(new_cpf.Substring(0, 9)) == new_cpf.Substring(9, 2))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Calcula o Digito verificador de um CPF informado  
        /// </summary>
        /// <param name="cpf">int64 com o CPF contendo 9 digitos e sem o digito verificador</param>
        /// <returns>string com o digito calculado do CPF ou null caso o cpf informado for maior que 9 digitos</returns>
        public static string CalculaDigCPF(long cpf)
        {
            return CalculaDigCPF(cpf.ToString("D9"));
        }

        /// <summary>
        /// Calcula o Digito verificador de um CPF informado  
        /// </summary>
        /// <param name="cpf">string com o CPF contendo 9 digitos e sem o digito verificador</param>
        /// <returns>string com o digito calculado do CPF ou null caso o cpf informado for maior que 9 digitos</returns>
        public static string CalculaDigCPF(string cpf)
        {
            // Declara variaveis para uso
            string new_cpf = "";
            string digito = "";
            int Aux1 = 0;
            int Aux2 = 0;

            // Retira carcteres invalidos não numericos da string
            for (int i = 0; i < cpf.Length; i++)
            {
                if (isDigito(cpf.Substring(i, 1)))
                {
                    new_cpf += cpf.Substring(i, 1);
                }
            }

            // Ajusta o Tamanho do CPF para 9 digitos completando com zeros a esquerda
            new_cpf = Convert.ToInt64(new_cpf).ToString("D9");

            // Caso o tamanho do CPF informado for maior que 9 digitos retorna nulo
            if (new_cpf.Length > 9)
            {
                return null;
            }

            // Calcula o primeiro digito do CPF
            Aux1 = 0;

            for (int i = 0; i < new_cpf.Length; i++)
            {
                Aux1 += Convert.ToInt32(new_cpf.Substring(i, 1)) * (10 - i);
            }

            Aux2 = 11 - (Aux1 % 11);

            // Carrega o primeiro digito na variavel digito
            if (Aux2 > 9)
            {
                digito += "0";
            }
            else
            {
                digito += Aux2.ToString();
            }

            // Adiciona o primeiro digito ao final do CPF para calculo do segundo digito
            new_cpf += digito;

            // Calcula o segundo digito do CPF
            Aux1 = 0;

            for (int i = 0; i < new_cpf.Length; i++)
            {
                Aux1 += Convert.ToInt32(new_cpf.Substring(i, 1)) * (11 - i);
            }

            Aux2 = 11 - (Aux1 % 11);

            // Carrega o segundo digito na variavel digito
            if (Aux2 > 9)
            {
                digito += "0";
            }
            else
            {
                digito += Aux2.ToString();
            }

            return digito;
        }

        private static bool ValidaDigitosIguais(string cpf)
        {
            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidaEmail(string email)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, strModelo))
            {
                return true;
            }
            return false;
        }
    }
}
