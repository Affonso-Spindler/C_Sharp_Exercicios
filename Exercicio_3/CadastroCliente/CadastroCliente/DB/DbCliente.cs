using CadastroCliente.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.DB
{
    public class DbCliente
    {
        public static void Delete(int codCliente)
        {
            try
            {
                string strSql = @"DELETE FROM CLIENTES WHERE codcliente = @codcliente";

                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    using (MySqlCommand comando = new MySqlCommand(strSql, conn))
                    {
                        comando.Parameters.AddWithValue("@codcliente", codCliente);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Ocorreu um erro de Banco de Dados: " + e.Message);
            }
        }

        public static void Insert(CLIENTE cliente)
        {
            try
            {
                string strSql = @"INSERT INTO CLIENTES (nomcliente, email, indtipopessoa, cpfcnpj, ddd1, telefone1, ddd2, telefone2, datnascimento, idade, cep, logradouro, bairro, numero, complemento, localidade, uf)
                                    VALUES(@Nomcliente, @Email, @Indtipopessoa, @Cpfcnpj, @Ddd1, @Telefone1, @Ddd2, @Telefone2, @Datnascimento, @Idade, @Cep, @Logradouro, @Bairro, @Numero, @Complemento, @Localidade, @Uf);
                              SELECT LAST_INSERT_ID()";


                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    using (MySqlCommand comando = new MySqlCommand(strSql, conn))
                    {
                        comando.Parameters.AddWithValue("@Nomcliente", cliente.Nomcliente);
                        comando.Parameters.AddWithValue("@Email", cliente.Email);
                        comando.Parameters.AddWithValue("@Indtipopessoa", cliente.Indtipopessoa);
                        comando.Parameters.AddWithValue("@Cpfcnpj", cliente.Cpfcnpj);
                        comando.Parameters.AddWithValue("@Ddd1", cliente.Ddd1);
                        comando.Parameters.AddWithValue("@Telefone1", cliente.Telefone1);
                        comando.Parameters.AddWithValue("@Ddd2", cliente.Ddd2);
                        comando.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
                        comando.Parameters.AddWithValue("@Datnascimento", cliente.Datnascimento);
                        comando.Parameters.AddWithValue("@Idade", cliente.Idade);
                        comando.Parameters.AddWithValue("@Cep", cliente.Cep);
                        comando.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
                        comando.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                        comando.Parameters.AddWithValue("@Numero", cliente.Numero);
                        comando.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                        comando.Parameters.AddWithValue("@Localidade", cliente.Localidade);
                        comando.Parameters.AddWithValue("@Uf", cliente.Uf);
                        cliente.Codcliente = Convert.ToInt32(comando.ExecuteScalar());
                    }
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Ocorreu um erro de Banco de Dados: " + e.Message);
            }
        }

        public static void Update(CLIENTE cliente)
        {
            try
            {
                string strSql = @"UPDATE CLIENTES SET Nomcliente = @Nomcliente, Email = @Email
                                , Indtipopessoa = @Indtipopessoa, Ddd1 = @Ddd1, Telefone1 = @Telefone1, Ddd2 = @Ddd2
                                , Telefone2 = @Telefone2, Datnascimento = @Datnascimento, Idade = @Idade
                                , Cpfcnpj = @Cpfcnpj, Cep = @Cep, Logradouro = @Logradouro, Bairro = @Bairro
                                , Numero = @Numero, Complemento = @Complemento, Uf = @Uf, Localidade = @Localidade
                                WHERE Codcliente = @Codcliente";

                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    using (MySqlCommand comando = new MySqlCommand(strSql, conn))
                    {
                        comando.Parameters.AddWithValue("@Codcliente", cliente.Codcliente);
                        comando.Parameters.AddWithValue("@Cpfcnpj", cliente.Cpfcnpj);
                        comando.Parameters.AddWithValue("@Nomcliente", cliente.Nomcliente);
                        comando.Parameters.AddWithValue("@Email", cliente.Email);
                        comando.Parameters.AddWithValue("@Indtipopessoa", cliente.Indtipopessoa);
                        comando.Parameters.AddWithValue("@Ddd1", cliente.Ddd1);
                        comando.Parameters.AddWithValue("@Telefone1", cliente.Telefone1);
                        comando.Parameters.AddWithValue("@Ddd2", cliente.Ddd2);
                        comando.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
                        comando.Parameters.AddWithValue("@Datnascimento", cliente.Datnascimento);
                        comando.Parameters.AddWithValue("@Idade", cliente.Idade);
                        comando.Parameters.AddWithValue("@Cep", cliente.Cep);
                        comando.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
                        comando.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                        comando.Parameters.AddWithValue("@Numero", cliente.Numero);
                        comando.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                        comando.Parameters.AddWithValue("@Localidade", cliente.Localidade);
                        comando.Parameters.AddWithValue("@Uf", cliente.Uf);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Ocorreu um erro de Banco de Dados: " + e.Message);
            }
        }

        public static CLIENTE Get(int codcliente)
        {
            try
            {

                string strSql = @"SELECT * FROM CLIENTES WHERE codcliente = @codcliente";

                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    using (MySqlCommand comando = new MySqlCommand(strSql, conn))
                    {
                        MySqlDataReader dr;

                        comando.Parameters.AddWithValue("@codcliente", codcliente);
                        dr = comando.ExecuteReader();

                        CLIENTE cliente = new CLIENTE();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                cliente.Codcliente = Convert.ToInt32(dr["codcliente"]);
                                cliente.Nomcliente = dr["nomcliente"].ToString();
                                cliente.Email = dr["email"].ToString();
                                cliente.Indtipopessoa = Convert.ToInt16(dr["indtipopessoa"]);
                                cliente.Cpfcnpj = dr["cpfcnpj"].ToString();
                                cliente.Ddd1 = dr["ddd1"].ToString();
                                cliente.Telefone1 = dr["telefone1"].ToString();
                                cliente.Ddd2 = dr["ddd2"].ToString();
                                cliente.Telefone2 = dr["telefone2"].ToString();
                                cliente.Datnascimento = Convert.ToDateTime(dr["datnascimento"]);
                                cliente.Idade = Convert.ToInt16(dr["idade"]);
                                cliente.Cep= dr["cep"].ToString();
                                cliente.Logradouro= dr["logradouro"].ToString();
                                cliente.Localidade= dr["localidade"].ToString();
                                cliente.Bairro= dr["bairro"].ToString();
                                cliente.Numero= dr["numero"].ToString();
                                cliente.Uf = dr["uf"].ToString();
                                cliente.Complemento = dr["complemento"].ToString();
                            }
                        }
                        return cliente;
                    }
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Ocorreu um erro de Banco de Dados: " + e.Message);
            }
        }

        public static DataTable BuscarCliente(string nomCliente = null, string email = null)
        {
            try
            {
                DataTable dt = new DataTable();
                string strSql = @"SELECT codcliente, CASE indtipopessoa WHEN 0 THEN 'Física' ELSE 'Jurídica' END AS tipopessoa
                                    , Cpfcnpj, nomcliente, email FROM CLIENTES WHERE 1 = 1 ";

                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    using (MySqlCommand comando = new MySqlCommand(strSql, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(nomCliente))
                        {
                            strSql += string.Format(" AND nomcliente like '%{0}%'", nomCliente);
                        }
                        if (!string.IsNullOrWhiteSpace(email))
                        {
                            strSql += string.Format(" AND email like '%{0}%'", email);
                        }
                        dt.Load(comando.ExecuteReader());

                        return dt;
                    }
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Ocorreu um erro de Banco de Dados: " + e.Message);
            }
        }

        public static bool ValidaCPFCNPJCadastrado(string cpfcnpj, int? codcliente = null)
        {
            try
            {
                string strSql = @"SELECT 1 FROM CLIENTES WHERE cpfcnpj = @cpfcnpj";

                if (codcliente.HasValue)
                {
                    strSql += " AND codcliente != @codcliente";
                }

                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    using (MySqlCommand comando = new MySqlCommand(strSql, conn))
                    {
                        comando.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);

                        if (codcliente.HasValue)
                        {
                            comando.Parameters.AddWithValue("@codcliente", codcliente);
                        }
                        bool exists = comando.ExecuteScalar() != DBNull.Value ? Convert.ToBoolean(comando.ExecuteScalar()) : false;

                        return exists;
                    }
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Ocorreu um erro de Banco de Dados: " + e.Message);
            }
        }
    }
}

