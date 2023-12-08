using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace PCs_Maik
{
    public class Query
    {
        NpgsqlConnection? connection;

        public Query()
        {
            connection = null;
        }

        public void setConnection(NpgsqlConnection conn)
        {
            connection = conn;
        }

        public DataTable DBreader(string query)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;


            NpgsqlDataReader DR = command.ExecuteReader();
            DataTable DT = new DataTable();

            if (DR.HasRows)
                DT.Load(DR);

            connection.Close();  //Release the connection from the executed query
            return DT;
        }

        public void DBnonQuery(string query)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;

            command.ExecuteNonQuery();

            connection.Close();  //Release the connection from the executed query
        }

        public bool checkInputID(String S)
        {
            if (String.IsNullOrEmpty(S) || !int.TryParse(S, out int i))
            {
                MessageBox.Show("Error, el ID ingresado no es valido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
