using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroport
{
    public partial class Authorization : Form
    {
        AuthorizationUser AutUser = new AuthorizationUser();
        //RegistrationUser RegUser = new RegistrationUser();

        SqlConnection sqlConnection;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizam\OneDrive\Документы\OOPKursovik\Aeroport\DataBaseAeport.mdf;Integrated Security=True";

        public Authorization()
        {
            InitializeComponent();
        }


        private void Admin_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizam\OneDrive\Документы\OOPKursovik\Aeroport\DataBaseAeport.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();



            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE [Login] = @log AND [Password] = @pass", sqlConnection);

            command.Parameters.AddWithValue("log", Login.Text);
            command.Parameters.AddWithValue("pass", Parol.Text);

            AutUser.AutUser(Login.Text, Parol.Text);

            adapter.SelectCommand = command;
            adapter.Fill(table);


            string name = Login.Text;
            string password = Parol.Text;


            if (table.Rows.Count > 0 )
            {
                int userid = Convert.ToInt32(table.Rows[0][0].ToString());
                this.DialogResult = DialogResult.OK;
                UserId.setGlobalUserId(userid);
                frmMain form2 = new frmMain();
                form2.Show();
                Login.Clear();
                Parol.Clear();              
            }

            else if(name == "" && password != "")
                MessageBox.Show("Введите логин!");

            else if (name != "" && password == "")
                MessageBox.Show("Введите пароль!");

            else if (name == "" && password == "")
                MessageBox.Show("Введите логин и пароль!");

            else
                MessageBox.Show("Неправильный логин или пароль!");
            
        }

        

    }
}
