using laba4;
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
    public partial class frmFilter : Form
    {

        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBaseAeport.mdf;Integrated Security=True";
        string sql = "SELECT * FROM Information";
        SqlConnection sqlConnection;

        public frmFilter()
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

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Familia like '{0}%'", textBox1.Text);
            }
            else if (textBox2.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Name like '{0}%'", textBox2.Text);
            }
            else if (textBox7.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Compamia like '{0}%'", textBox7.Text);
            }
            else if (textBox10.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("DateTime like '{0}%'", textBox10.Text);
            }

            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Familia like '{0}%' AND Name like '{0}%'", textBox1.Text, textBox2.Text);
            }

            else
                MessageBox.Show("Введите данные!");

            textBox3.Text = dataGridView1.RowCount.ToString();

        }

        private void frmFilter_Load(object sender, EventArgs e)
        {
          
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            informationBindingSource.DataSource = this.dataBaseAeportDataSet1.Information;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
