
namespace Aeroport
{
    partial class frmFilter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_apply = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dataBaseAeportDataSet4 = new Aeroport.DataBaseAeportDataSet4();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationTableAdapter = new Aeroport.DataBaseAeportDataSet4TableAdapters.InformationTableAdapter();
            this.dataBaseAeportDataSet5 = new Aeroport.DataBaseAeportDataSet5();
            this.informationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.informationTableAdapter1 = new Aeroport.DataBaseAeportDataSet5TableAdapters.InformationTableAdapter();
            this.dataBaseAeportDataSet1 = new Aeroport.DataBaseAeportDataSet1();
            this.informationTableAdapter2 = new Aeroport.DataBaseAeportDataSet1TableAdapters.InformationTableAdapter();
            this.tableAdapterManager = new Aeroport.DataBaseAeportDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataBaseAeportDataSet6 = new Aeroport.DataBaseAeportDataSet6();
            this.informationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.informationTableAdapter3 = new Aeroport.DataBaseAeportDataSet6TableAdapters.InformationTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(486, 77);
            this.button_apply.Margin = new System.Windows.Forms.Padding(2);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(144, 46);
            this.button_apply.TabIndex = 1;
            this.button_apply.Text = "Применить фильтр";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Дата и время отправления";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Компания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Фамилия";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(206, 114);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(191, 20);
            this.textBox7.TabIndex = 62;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(206, 147);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(191, 20);
            this.textBox10.TabIndex = 59;
            // 
            // dataBaseAeportDataSet4
            // 
            this.dataBaseAeportDataSet4.DataSetName = "DataBaseAeportDataSet4";
            this.dataBaseAeportDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.dataBaseAeportDataSet4;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // dataBaseAeportDataSet5
            // 
            this.dataBaseAeportDataSet5.DataSetName = "DataBaseAeportDataSet5";
            this.dataBaseAeportDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationBindingSource1
            // 
            this.informationBindingSource1.DataMember = "Information";
            this.informationBindingSource1.DataSource = this.dataBaseAeportDataSet5;
            // 
            // informationTableAdapter1
            // 
            this.informationTableAdapter1.ClearBeforeFill = true;
            // 
            // dataBaseAeportDataSet1
            // 
            this.dataBaseAeportDataSet1.DataSetName = "DataBaseAeportDataSet1";
            this.dataBaseAeportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationTableAdapter2
            // 
            this.informationTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InformationTableAdapter = this.informationTableAdapter2;
            this.tableAdapterManager.UpdateOrder = Aeroport.DataBaseAeportDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(815, 240);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataBaseAeportDataSet6
            // 
            this.dataBaseAeportDataSet6.DataSetName = "DataBaseAeportDataSet6";
            this.dataBaseAeportDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationBindingSource2
            // 
            this.informationBindingSource2.DataMember = "Information";
            this.informationBindingSource2.DataSource = this.dataBaseAeportDataSet6;
            // 
            // informationTableAdapter3
            // 
            this.informationTableAdapter3.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(687, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Колличество найденных пассажиров";
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_apply);
            this.Name = "frmFilter";
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.frmFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox10;
        private DataBaseAeportDataSet4 dataBaseAeportDataSet4;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private DataBaseAeportDataSet4TableAdapters.InformationTableAdapter informationTableAdapter;
        private DataBaseAeportDataSet5 dataBaseAeportDataSet5;
        private System.Windows.Forms.BindingSource informationBindingSource1;
        private DataBaseAeportDataSet5TableAdapters.InformationTableAdapter informationTableAdapter1;
        private DataBaseAeportDataSet1 dataBaseAeportDataSet1;
        private DataBaseAeportDataSet1TableAdapters.InformationTableAdapter informationTableAdapter2;
        private DataBaseAeportDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataBaseAeportDataSet6 dataBaseAeportDataSet6;
        private System.Windows.Forms.BindingSource informationBindingSource2;
        private DataBaseAeportDataSet6TableAdapters.InformationTableAdapter informationTableAdapter3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}