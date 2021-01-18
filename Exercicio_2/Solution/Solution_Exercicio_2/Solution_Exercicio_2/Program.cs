using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Solution_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // "C:\__Aprendizagem\C_Sharp_Exercices\Exercicio_1\Soluction\Soluction_Exe_1\bin\Debug"
            string pathOrigem = ConfigurationManager.AppSettings["CaminhoOrigem"];
            string pathDestino = ConfigurationManager.AppSettings["CaminhoDestino"];

            string log = string.Empty;
            string logErro = string.Empty;


            ProcessaArquivos();
            ProcessaLogs();
            Console.ReadKey();

            void ProcessaArquivos()
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(pathOrigem) || string.IsNullOrWhiteSpace(pathDestino))
                    {
                        Console.WriteLine("Arquivo de configuração inválido!");
                        Console.ReadKey();
                        return;
                    }
                    if (!Directory.Exists(pathDestino))
                    {
                        Directory.CreateDirectory(pathDestino);
                    }
                    foreach (string arquivo in Directory.GetFiles(pathOrigem, "*.txt"))
                    {
                        string nomArquivo = arquivo.Replace(Path.Combine(pathOrigem,""), "");
                        nomArquivo = arquivo.Substring(pathOrigem.Length + 1); // +1 para remover a última '\'
                        
                        string[] arquivoLido = File.ReadAllLines(arquivo, Encoding.UTF8);

                        if (!Valida(arquivoLido, nomArquivo))
                        {
                            string pathErros = Path.Combine(pathOrigem, "Erros");
                            if (!Directory.Exists(pathErros))
                            {
                                Directory.CreateDirectory(pathErros);
                            }

                            if (File.Exists(Path.Combine(pathErros, nomArquivo)))
                            {
                                File.Delete(Path.Combine(pathErros, nomArquivo));
                            }
                            File.Move(arquivo, Path.Combine(pathErros, nomArquivo));

                            continue;
                        }

                        string codCliente;
                        string tipoArquivo = arquivoLido[0].Substring(0, 4).ToUpper();
                        string nomCliente;

                        if (string.Equals(tipoArquivo, "CADS") == true)
                        {
                            codCliente = arquivoLido[0].Substring(10, 12).Trim();
                            nomCliente = GetNomCliente(codCliente);
                            log += string.Format("{0} - {1}", nomCliente, nomArquivo) + Environment.NewLine;
                        }
                        else //ITEM
                        {
                            codCliente = arquivoLido[0].Substring(20, 12).Trim();
                            nomCliente = GetNomCliente(codCliente);
                            decimal qtd = Convert.ToDecimal(arquivoLido[1].Substring(45, 3).Trim());
                            log += string.Format("{0} - {1} - {2} unidades compradas", nomCliente, nomArquivo, qtd) + Environment.NewLine;
                        }


                        if (!Directory.Exists(Path.Combine(pathDestino, nomCliente)))
                        {
                            Directory.CreateDirectory(Path.Combine(pathDestino, nomCliente));
                        }

                        if (File.Exists(Path.Combine(pathDestino, nomCliente, nomArquivo)))
                        {
                            File.Delete(Path.Combine(pathDestino, nomCliente, nomArquivo));
                        }
                        File.Move(arquivo, Path.Combine(pathDestino, nomCliente, nomArquivo));
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }

            void ProcessaLogs()
            {
                if (!string.IsNullOrWhiteSpace(logErro))
                {
                    string nomLogErro = "Log_Processamento_Erros_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".log";
                    File.WriteAllText(Path.Combine(pathOrigem, nomLogErro), logErro);
                }

                if (!string.IsNullOrWhiteSpace(log))
                {
                    string nomLog = "Log_Processamento_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".log";
                    File.WriteAllText(Path.Combine(pathOrigem, nomLog), log);
                }
            }

            bool Valida(string[] arquivo, string nomArquivo)
            {
                //Valida se o arquivo está vazio
                if (arquivo.Length == 0)
                {
                    logErro += string.Format("{0} - arquivo vazio", nomArquivo) + Environment.NewLine;
                    return false;
                }

                //Valida se é possível obter algum tipo de arquivo
                if (arquivo[0].Length < 4)
                {
                    logErro += string.Format("{0} - impossível classificar o arquivo como CADASTRO ou ITEM", nomArquivo) + Environment.NewLine;
                    return false;
                }

                //Valida o Tipo do arquivo
                string tipoArquivo = arquivo[0].Substring(0, 4).ToUpper();

                if (!string.Equals(tipoArquivo, "CADS") && !string.Equals(tipoArquivo, "ITEM"))
                {
                    logErro += string.Format("{0} - não foi possível classificar o arquivo como CADASTRO ou ITEM", nomArquivo) + Environment.NewLine;
                    return false;
                }

                string codCads = arquivo[0].Substring(10, 12).Trim();
                string codItem = arquivo[0].Substring(20, 12).Trim();

                if ((string.Equals(tipoArquivo, "CADS") && GetNomCliente(codCads) == null)
                    || (string.Equals(tipoArquivo, "ITEM") && GetNomCliente(codItem) == null))
                {
                    logErro += string.Format("{0} - cliente inexistente na configuração", nomArquivo) + Environment.NewLine;
                    return false;
                }

                //Começa Validação para Arquivo tipo ITEM
                if (string.Equals(tipoArquivo, "ITEM"))
                {
                    string nomcliente = GetNomCliente(codItem);
                    if (!string.IsNullOrWhiteSpace(nomcliente))
                    {
                        nomcliente = string.Format("{0} - ", nomcliente);
                    }

                    //Valida se tem a segunda linha do ITEM
                    if (arquivo.Length < 2)
                    {
                        logErro += string.Format("{0}{1} - Quantidade inválida ou igual a zero", nomcliente, nomArquivo) + Environment.NewLine;
                        return false;
                    }

                    //Valida se é possível obter a Quantidade
                    decimal qtd = 0;
                    if (!decimal.TryParse(arquivo[1].Substring(45, 3).Trim(), out qtd) || qtd == 0)
                    {
                        logErro += string.Format("{0}{1} - Quantidade inválida ou igual a zero", nomcliente, nomArquivo) + Environment.NewLine;
                        return false;
                    }
                }

                return true;
            }

            string GetNomCliente(string codcliente)
            {
                string result = ConfigurationManager.AppSettings[codcliente] ?? null;
                return result;
            }

        }

    }
}
