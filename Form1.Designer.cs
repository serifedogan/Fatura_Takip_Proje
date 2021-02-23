
namespace Fatura_Takip_Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonOdemTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenecekTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faturaDataSet = new Fatura_Takip_Proje.faturaDataSet();
            this.faturaTableAdapter = new Fatura_Takip_Proje.faturaDataSetTableAdapters.faturaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaNoDataGridViewTextBoxColumn,
            this.adSoyadiDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.faturaTarihiDataGridViewTextBoxColumn,
            this.sonOdemTarihiDataGridViewTextBoxColumn,
            this.odenecekTutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.faturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "Fatura_No";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "Fatura_No";
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
            // 
            // adSoyadiDataGridViewTextBoxColumn
            // 
            this.adSoyadiDataGridViewTextBoxColumn.DataPropertyName = "Ad_Soyadi";
            this.adSoyadiDataGridViewTextBoxColumn.HeaderText = "Ad_Soyadi";
            this.adSoyadiDataGridViewTextBoxColumn.Name = "adSoyadiDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "Kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "Kdv";
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            // 
            // faturaTarihiDataGridViewTextBoxColumn
            // 
            this.faturaTarihiDataGridViewTextBoxColumn.DataPropertyName = "Fatura_Tarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.HeaderText = "Fatura_Tarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.Name = "faturaTarihiDataGridViewTextBoxColumn";
            // 
            // sonOdemTarihiDataGridViewTextBoxColumn
            // 
            this.sonOdemTarihiDataGridViewTextBoxColumn.DataPropertyName = "Son_Odem_Tarihi";
            this.sonOdemTarihiDataGridViewTextBoxColumn.HeaderText = "Son_Odem_Tarihi";
            this.sonOdemTarihiDataGridViewTextBoxColumn.Name = "sonOdemTarihiDataGridViewTextBoxColumn";
            // 
            // odenecekTutarDataGridViewTextBoxColumn
            // 
            this.odenecekTutarDataGridViewTextBoxColumn.DataPropertyName = "Odenecek_Tutar";
            this.odenecekTutarDataGridViewTextBoxColumn.HeaderText = "Odenecek_Tutar";
            this.odenecekTutarDataGridViewTextBoxColumn.Name = "odenecekTutarDataGridViewTextBoxColumn";
            // 
            // faturaBindingSource
            // 
            this.faturaBindingSource.DataMember = "fatura";
            this.faturaBindingSource.DataSource = this.faturaDataSet;
            // 
            // faturaDataSet
            // 
            this.faturaDataSet.DataSetName = "faturaDataSet";
            this.faturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturaTableAdapter
            // 
            this.faturaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fatura No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kdv:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fatura Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Son Ödeme Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ödenecek Tutar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 166);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "YENİ KAYIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "KAYDET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 37);
            this.button3.TabIndex = 17;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(593, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 35);
            this.button4.TabIndex = 18;
            this.button4.Text = "DEĞİŞTİR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(131, 199);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(144, 20);
            this.textBox7.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(991, 500);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "FATURA TAKİP PROGRAMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private faturaDataSet faturaDataSet;
        private System.Windows.Forms.BindingSource faturaBindingSource;
        private faturaDataSetTableAdapters.faturaTableAdapter faturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonOdemTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenecekTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
    }
}

