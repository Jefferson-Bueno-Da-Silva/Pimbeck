using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace desktopv2
{
    class AuthModel: DAO
    {
        //Pega todos os registros
        public Boolean ValidateUser(string email, string passWord)
        {
            Boolean value;
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();

                    String SqlCommand = String.Format("SELECT senha_usuario FROM usuarios WHERE email_usuario = '{0}' ", email);
                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(SqlCommand, pgsqlConnection))
                    {
                        var reader = pgsqlcommand.ExecuteReader();
                        if (reader.Read())
                        {
                            value = reader.GetString(0) == passWord;
                        }
                        else
                        {
                            value = false;
                        }

                        reader.Close();
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
            return value;
        }
    }
}
