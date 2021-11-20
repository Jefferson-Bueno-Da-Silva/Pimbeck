using System;
using Npgsql;
using System.Data;

namespace desktopv2
{
    class DB : DAO
    {
        //Pega todos os registros
        public DataTable GetAll(string SqlCommand)
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(SqlCommand, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }

        //Inserir registros
        public void InserirRegistros( string SqlCommand )
        {
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(SqlCommand, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        public void Updade( string SqlCommand )
        {
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(SqlCommand, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        public void Delete( string table, string whereQuery )
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("Delete From {0} Where {1}", table, whereQuery);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
