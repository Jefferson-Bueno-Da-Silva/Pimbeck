using System;
using Npgsql;
using System.Data;

namespace desktopv2
{
    class FuncionarioDB : DAO
    {
        //Pega todos os registros
        public DataTable GetTodosRegistros()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from funcionarios order by id_funcionario";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
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

        public void Set()
        {
        }

        public void Updade()
        {
        }

        public void Delete()
        {
        }
    }
}
