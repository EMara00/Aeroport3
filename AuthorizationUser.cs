using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroport
{
    class AuthorizationUser
    {
        SqlConnection sqlConnection;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizam\OneDrive\Документы\OOPKursovik\Aeroport\DataBaseAeport.mdf;Integrated Security=True";

        public void AutUser(string login, string pass)
        {
            sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE [Login] = @log AND [Password] = @pass", sqlConnection);

            command.Parameters.AddWithValue("log", login);

            command.Parameters.AddWithValue("pass", pass);

            command.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId.GlobalUserId;

            sqlConnection.Open();

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
