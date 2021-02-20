using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroport
{
    class DeletePass
    {
        SqlConnection sqlConnection;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizam\OneDrive\Документы\OOPKursovik\Aeroport\DataBaseAeport.mdf;Integrated Security=True";

        public bool DeleteNotes(string id)
        {
            sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("DELETE FROM [Information] WHERE [Id]=@Id", sqlConnection);

            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            sqlConnection.Open();

            command.ExecuteNonQuery();

            sqlConnection.Close();

            return true;

        }
    }
}
