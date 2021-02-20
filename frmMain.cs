using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Aeroport
{
    public partial class frmMain : Form
    {
        
        GetPass pass = new GetPass();

        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBaseAeport.mdf;Integrated Security=True";
        string sql = "SELECT * FROM Information";
        SqlConnection sqlConnection;

        public frmMain()
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
   

            }


        }

        private void Form_Data_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseAeportDataSet3.Information". При необходимости она может быть перемещена или удалена.
            this.informationTableAdapter1.Fill(this.dataBaseAeportDataSet3.Information);


            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [Information]", sqlConnection);

            SqlCommand command_2 = new SqlCommand("SELECT SELECT Id, Familia, Name, Otchestvo, Document, Nomer, Grazdanstvo, Compania, Class, StrOtpr, DateTime, StrPrib FROM Information WHERE userid =@uid");

            command_2.Parameters.Add("@uid", SqlDbType.Int).Value = UserId.GlobalUserId;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
         

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseAeportDataSet1.Information". При необходимости она может быть перемещена или удалена.
            this.informationTableAdapter.Fill(this.dataBaseAeportDataSet1.Information);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            



            }

        }

        public void AddPassazir()
        {
            informationTableAdapter.Fill(this.dataBaseAeportDataSet1.Information);
        }

        //добавляет пользователя
        private void Add_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);

            frmCreate af = new frmCreate(this);
            af.Show();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                PassDelete();


            }
            
        }

        public void PassDelete()
        {
            //удаляет выделенный столбец
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DeletePass del = new DeletePass();
                del.DeleteNotes(textBox1.Text);
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
                MessageBox.Show("Введите ID!");
        }

        private void Save_Click(object sender, EventArgs e)
        {

            DataSet ds2 = new DataSet();
            SqlConnection dataBaseConnection = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Id, Familia, Name, Otchestvo, Document, Nomer, Grazdanstvo, Compania, Class, StrOtpr, DateTime, StrPrib FROM Information", dataBaseConnection);
            //Вторым параметром ты присваиваешь имя для текущей таблицы в датасете
            dataAdapter.Fill(ds2, "Information");
            //Здесь указываешь имя нужной таблицы            
            dataGridView1.DataSource = ds2.Tables["Information"];

        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmSearch sf = new frmSearch();
            sf.Owner = this;
            sf.Show();
        }
 

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            //frmFilter fi = new frmFilter();
            //fi.Show();

           



            if (textBox3.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Familia like '{0}%'", textBox3.Text);                 
            }
            else if (textBox2.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Name like '{0}%'", textBox2.Text);
            }
            else if (textBox7.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Compania like '{0}%'", textBox7.Text);
            }
            else if (textBox10.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("DateTime like '{0}%'", textBox10.Text);
            }

            else
                MessageBox.Show("Введите данные!");

        }
    }
}
