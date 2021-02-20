using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroport
{
    class AddPass
    {
    
        SqlConnection sqlConnection;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizam\OneDrive\Документы\OOPKursovik\Aeroport\DataBaseAeport.mdf;Integrated Security=True";

        public bool AddNotes(string familia, string name, string otchestvo, string document, string nomer, string grazdanstvo, string compania, string class_, string strOtpr, string dateTime, string strPrib, int userid)
        {


            sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("INSERT INTO Information VALUES (@Familia, @Name, @Otchestvo, @Document, @Nomer, @Grazdanstvo, @Compania, @Class, @StrOtpr, @DateTime, @StrPrib, @UserId)", sqlConnection);

            command.Parameters.AddWithValue("@Familia", familia);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Otchestvo", otchestvo);
            command.Parameters.AddWithValue("@Document", document);
            command.Parameters.AddWithValue("@Nomer", nomer);
            command.Parameters.AddWithValue("@Grazdanstvo", grazdanstvo);
            command.Parameters.AddWithValue("@Compania", compania);
            command.Parameters.AddWithValue("@Class", class_);
            command.Parameters.AddWithValue("@StrOtpr", strOtpr);
            command.Parameters.AddWithValue("@DateTime", dateTime);
            command.Parameters.AddWithValue("@StrPrib", strPrib);

            command.Parameters.Add("@UserId", SqlDbType.Int).Value = userid;

            sqlConnection.Open();

            command.ExecuteNonQuery();

            return true;



        }
    }
}
