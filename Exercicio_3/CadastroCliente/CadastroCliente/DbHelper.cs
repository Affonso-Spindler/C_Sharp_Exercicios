using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    public class DbHelper
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionMySQL"].ConnectionString);

            try
            {
                if (conexao.State != System.Data.ConnectionState.Open)
                {
                    conexao.Open();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }

            return conexao;

        }
    }
}
