using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace desktopv2
{
    class DAO
    {
        private static string Host = "motty.db.elephantsql.com";
        private static string User = "mvnpimxw";
        private static string DBname = "mvnpimxw";
        private static string Password = "oTYpXXi_4NERIzW3Io2maWvKWmMdfsvd";
        private static string Port = "5432";

        public string Get()
        {
            // Build connection string using parameters from portal
            //
            string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);


            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM clientes", conn))
                {

                    var reader = command.ExecuteReader();
                    var teste = string.Format(
                        "Reading from table=({0}, {1}, {2})",
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetInt32(2).ToString()
                        );
                    reader.Close();
                    Console.WriteLine(teste);
                    return teste;
                }
            }
        }
    }
}
