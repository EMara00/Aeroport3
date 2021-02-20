using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroport
{
    class GetPass
    {
        SqlConnection sqlConnection;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizam\OneDrive\Документы\OOPKursovik\Aeroport\DataBaseAeport.mdf;Integrated Security=True";
        public DataTable getNotes(int userid)
        {
            sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("SELECT Id, Familia, Name, Otchestvo, Document, Nomer, Grazdanstvo, Compania, Class, StrOtpr, DateTime, StrPrib FROM Information WHERE userid =@uid", sqlConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;

        }

    }
}
