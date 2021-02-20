using laba4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aeroport
{
    public partial class frmCreate : Form
    {
        frmMain Owner;

        Label[] name;
        TextBox[] textBox;
        List<Field> fields;

        AddPass Note = new AddPass();
        GetPass NotePass = new GetPass();

        DataGridView dataGridView1;
        DataSet ds;
        DataBaseAeportDataSet1 dataBaseAeportDataSet1;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBaseAeport.mdf;Integrated Security=True";
        string sql = "SELECT * FROM Information";

        
        public frmCreate(frmMain Owner)
        {
            this.Owner = Owner;
            InitializeComponent();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {


            fields = FieldTypeCol.get_value();
            int count = fields.Count;
            int[] x = { 10, 200 };
            int y = 10;

            name = new Label[count];
            textBox = new TextBox[count];

            for (int i = 0; i < count; i++)
            {
                name[i] = new Label();
                textBox[i] = new TextBox();
            }
            for (int i = 0; i < count; ++i)
            {
                y += 30;
                int index = 0;

                name[i].Text = fields[i].GetName();
                name[i].Left = x[index++];
                name[i].Top = y;
                name[i].Name = fields[i].TypeField();
                textBox[i].Width = 200;
                textBox[i].Left = x[index++];
                textBox[i].Top = y;
                name[i].Width = 180;
            }

            for (int i = 0; i < count; i++)
            {
                this.Controls.Add(name[i]);
                this.Controls.Add(textBox[i]);
            }

        }
        static public void AddPassenger(string[] fill_text)
        {
            List<Field> new_field = FieldTypeCol.get_value();
            for (int i = 0; i < fill_text.Count<string>(); ++i)
                new_field[i].SetValue(fill_text[i]);

            Passenger new_pass = new Passenger();
            new_pass.fields = new_field;
            FirmCol.add_pass(new_pass);
        }

        static public void AddPassToFile(string[] fill_text)
        {
            FileStream file = new FileStream("data.csv", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file, Encoding.GetEncoding(1251));
            string str = string.Join(";", fill_text);
            writer.Write(str);
            writer.WriteLine();
            writer.Close();
            file.Close();
        }
        private void Button_Add(object sender, EventArgs e)
        {
            int count = textBox.Count<TextBox>();

            string[] fill_text = new string[count];


            for (int i = 0; i < count; i++)
            {
                fill_text[i] = textBox[i].Text;


            }

            for (int i = 0; i < count; i++)
            {
                if (fill_text[i] == "")
                {
                    System.Windows.Forms.MessageBox.Show("Не все поля заполнены!");
                    return;
                }
            }
            AddPassenger(fill_text);
            AddPassToFile(fill_text);
            this.Close();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вид документа*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Гражданство*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Страна и город прибытия*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата и время отправления*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Страна и город отправления*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Класс*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Компания*";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.Location = new System.Drawing.Point(266, 290);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 40);
            this.button13.TabIndex = 20;
            this.button13.Text = "Добавить";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(130, 239);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 20);
            this.textBox5.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(540, 126);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(191, 20);
            this.textBox8.TabIndex = 28;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(540, 204);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(191, 20);
            this.textBox10.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(383, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 40);
            this.button3.TabIndex = 31;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(540, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Бизнес",
            "Первый",
            "Эконом"});
            this.comboBox1.Location = new System.Drawing.Point(540, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Поля отмеченные * - обязательны для заполнения";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Серия и номер*";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Пасспорт",
            "Свидетельство о рождении",
            "Заграничный пасспорт"});
            this.comboBox2.Location = new System.Drawing.Point(130, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 21);
            this.comboBox2.TabIndex = 37;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Qatar Airways",
            "Singapore Airlines",
            "ANA All Nippon Airways",
            "Cathay Pacific Airways",
            "Emirates",
            "EVA Air",
            "Hainan Airlines",
            "Qantas Airways",
            "Lufthansa",
            "Thai Airways",
            "Japan Airlines",
            "Garuda Indonesia",
            "Swiss International Air Lines",
            "China Southern Airlines",
            "Austrian Airlines",
            "Air New Zealand",
            "Bangkok Airways",
            "KLM Royal Dutch Airlines",
            "British Airways",
            "AirAsia",
            "Virgin Atlantic",
            "Aeroflot",
            "Air France",
            "Hong Kong Airlines",
            "Virgin Australia",
            "Iberia",
            "Turkish Airlines",
            "Asiana Airlines",
            "Etihad Airways",
            "Philippine Airlines",
            "Air Canada",
            "Finnair",
            "Cathay Dragon",
            "China Airlines",
            "Korean Air",
            "Malaysia Airlines",
            "EasyJet",
            "Aer Lingus",
            "Norwegian",
            "jetBlue Airways",
            "Delta Air Lines",
            "Aegean Airlines",
            "Oman Air",
            "Ethiopian Airlines",
            "Fiji Airways",
            "South African Airways",
            "Southwest Airlines",
            "AirAsia X",
            "LATAM",
            "Azul Airlines",
            "Air Astana",
            "Azerbaijan Airlines (AZAL)",
            "Jetstar Airways",
            "Alaska Airlines",
            "WestJet",
            "Vietnam Airlines",
            "Saudi Arabian Airlines",
            "IndiGo",
            "Ryanair",
            "Air Transat",
            "Air Mauritius",
            "SilkAir",
            "Eurowings",
            "Scoot",
            "SAS Scandinavian",
            "Royal Brunei Airlines",
            "LOT Polish",
            "United Airlines",
            "Vistara",
            "Avianca",
            "Gulf Air",
            "Alitalia",
            "AtlasGlobal",
            "American Airlines",
            "China Eastern Airlines",
            "TAP Portugal",
            "TUI Airways",
            "Copa Airlines",
            "Brussels Airlines",
            "Juneyao Airlines",
            "Jetstar Asia",
            "Porter Airlines",
            "Hawaiian Airlines",
            "American Eagle",
            "PAL Express",
            "Peach",
            "Air Malta",
            "Air Seychelles",
            "Air Dolomiti",
            "Kenya Airways",
            "Vueling Airlines",
            "Air Canada rouge",
            "Royal Air Maroc",
            "LEVEL",
            "Jet2.com",
            "S7 Airlines",
            "Royal Jordanian Airlines",
            "Flynas",
            "Air China",
            "Icelandair"});
            this.comboBox3.Location = new System.Drawing.Point(540, 55);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 21);
            this.comboBox3.TabIndex = 38;
            // 
            // frmCreate
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(774, 371);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreate";
            this.Text = "Добавить пассажира";
            this.Load += new System.EventHandler(this.frmCreate_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmCreate_Load_1(object sender, EventArgs e)
        {
            
        }

        public void removDublicate()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                        else
                            Note.AddNotes(textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.Text, textBox4.Text, textBox5.Text, comboBox3.Text, comboBox1.Text, textBox8.Text, dateTimePicker1.Text, textBox10.Text, UserId.GlobalUserId);

            }

        }
        

        public void button13_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrEmpty(comboBox2.Text) && !string.IsNullOrWhiteSpace(comboBox2.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrEmpty(comboBox3.Text) && !string.IsNullOrWhiteSpace(comboBox3.Text) && !string.IsNullOrEmpty(dateTimePicker1.Text) && !string.IsNullOrWhiteSpace(dateTimePicker1.Text) && !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) && !string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text) && !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text))
            {
                
                    Note.AddNotes(textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.Text, textBox4.Text, textBox5.Text, comboBox3.Text, comboBox1.Text, textBox8.Text, dateTimePicker1.Text, textBox10.Text, UserId.GlobalUserId);










                //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                //{
                //    if (row.Index != e.RowIndex & !row.IsNewRow)
                //    {
                //        if (row.Cells[0].Value.ToString() == e.FormattedValue.ToString())
                //        {
                //            dataGridView1.Rows[e.RowIndex].ErrorText =
                //                "Такой пассажир и данные o вылетe уже в таблице есть!";
                //            return;
                //        }
                //    }



                //DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
                //ds.Tables[0].Rows.Add(row);


                // }
                // dataGridView1.Rows[e.RowIndex].ErrorText = string.Empty;

            }
            else
            {
                MessageBox.Show("Не все обязательные поля заполнены!");

            }

            Convert.ToString(Owner.dataGridView1.DataSource = NotePass.getNotes(UserId.GlobalUserId));





        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }

}
