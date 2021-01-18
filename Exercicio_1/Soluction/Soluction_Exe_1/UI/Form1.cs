using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Soluction_Exe_1
{
    public partial class Form1 : Form
    {
        private string error = string.Empty;
        // "C:\__Aprendizagem\C_Sharp_Exercices\Exercicio_1\Soluction\Soluction_Exe_1\bin\Debug\Arquivos\Examples"
        private string path = Application.StartupPath + @"\Arquivos\Examples\";

        // "C:\__Aprendizagem\C_Sharp_Exercices\Exercicio_1\Soluction\Soluction_Exe_1\bin\Debug\Arquivos\Examples"
        private string pathLog = Application.StartupPath;

        public Form1()
        {
            InitializeComponent();
            txtpath.Text = path;
            txtpathlog.Text = pathLog;
        }

        private bool Valida(string[] arquivo, string patharquivo)
        {
            //Valida se o arquivo está vazio
            if (arquivo.Length == 0)
            {
                error += string.Format("Arquivo {0} vazio!", patharquivo) + Environment.NewLine;
                return false;
            }

            //Valida a primeira linha
            if (string.IsNullOrWhiteSpace(arquivo[0]))
            {
                error += string.Format("Arquivo {0} com a primeira linha vazia!", patharquivo) + Environment.NewLine;
                return false;
            }

            //Valida o Tipo do arquivo
            if (!string.Equals(arquivo[0].Substring(0, 4).ToUpper(), "CADS") && !string.Equals(arquivo[0].Substring(0, 4).ToUpper(), "ITEM"))
            {
                error += string.Format("Arquivo {0} não é do Tipo CADASTRO ou ITEM!", patharquivo) + Environment.NewLine;
                return false;
            }

            return true;
        }

        private string GetNomCliente(string codcliente)
        {
            switch (codcliente)
            {
                case "1231231":
                    return "Ubisoft";
                case "111222333444":
                    return "From_Software";
                case "987654321":
                    return "Steam";
                case "777888":
                    return "CD_Projekt_Red";
                default:
                    return null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ProcessaArquivos())
            {
                MessageBox.Show("Sucesso!");
            }
            if (error != string.Empty)
            {
                MessageBox.Show("Veja o Log com as falhas");
                File.WriteAllText(Application.StartupPath+@"\log.txt", error);
            }
        }

        private bool ProcessaArquivos()
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    error += string.Format("Caminho {0} não encontrado!", path) + Environment.NewLine;
                    MessageBox.Show(string.Format("Caminho não encontrado!", path));
                    return false;
                }

                foreach (string patharquivo in Directory.GetFiles(path, "*.txt"))
                {
                    string[] arquivoLido = File.ReadAllLines(patharquivo, Encoding.UTF8);

                    if (!Valida(arquivoLido, patharquivo))
                    {
                        continue;
                    }

                    OBJETO objeto = new OBJETO();

                    objeto.Pathorigem = patharquivo;

                    if (string.Equals(arquivoLido[0].Substring(0, 4).ToUpper(), "CADS") == true)
                    {
                        objeto.Tipoarquivo = Enums.TipoArquivo.Cadastro;
                        objeto.Codcliente = arquivoLido[0].Substring(10, 12).Trim();
                        objeto.Nomcliente = GetNomCliente(objeto.Codcliente);
                        objeto.Pathdestino = patharquivo.Replace("Examples", @"Consolidated\" + objeto.Nomcliente);
                    }

                    //Verifica se do tipo Item
                    else if (string.Equals(arquivoLido[0].Substring(0, 4).ToUpper(), "ITEM") == true)
                    {
                        objeto.Tipoarquivo = Enums.TipoArquivo.Item;
                        objeto.Codcliente = arquivoLido[0].Substring(20, 12).Trim();
                        objeto.Nomcliente = GetNomCliente(objeto.Codcliente);
                        objeto.Pathdestino = patharquivo.Replace("Examples", @"Consolidated\" + objeto.Nomcliente);
                    }

                    string pathclinte = path.Replace("Examples", "Consolidated") + objeto.Nomcliente;

                    if (!Directory.Exists(pathclinte))
                    {
                        Directory.CreateDirectory(pathclinte);
                    }

                    if (File.Exists(objeto.Pathdestino))
                    {
                        File.Delete(objeto.Pathdestino);
                    }
                    Directory.Move(objeto.Pathorigem, objeto.Pathdestino);
                }
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
