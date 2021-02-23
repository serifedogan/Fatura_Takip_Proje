using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Fatura_Takip_Proje
{
    public partial class Form1 : Form
    {

        //SqlConnection baglanti = new SqlConnection("Data Source = LENOVO - PC; Initial Catalog = fatura; Integrated Security = True;");
        SqlConnection baglanti = new SqlConnection("server=.;database=fatura;Integrated Security=true");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter guc = new SqlDataAdapter();
        DataSet dt = new DataSet();
        void listele()
        {
            baglanti.Open();
            SqlDataAdapter guc = new SqlDataAdapter("select * from fatura", baglanti);
            guc.Fill(dt, "fatura");
            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "fatura";
            guc.Dispose();
            baglanti.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'faturaDataSet.fatura' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.faturaTableAdapter.Fill(this.faturaDataSet.fatura);
            listele();
            textBox1.DataBindings.Add("Text", dt, "fatura.Fatura_No");
            textBox2.DataBindings.Add("Text", dt, "fatura.Ad_Soyadi");
            textBox3.DataBindings.Add("Text", dt, "fatura.Adres");
            textBox4.DataBindings.Add("Text", dt, "fatura.Kdv");
            dateTimePicker1.DataBindings.Add("Text", dt, "fatura.Fatura_Tarihi");
            dateTimePicker2.DataBindings.Add("Text", dt, "fatura.Son_Odem_Tarihi");
            textBox7.DataBindings.Add("Text", dt, "fatura.Odenecek_Tutar");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt, "fatura"].AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut.Parameters.AddWithValue("@FaturaNumarasi", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@KDVsi", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@Tutar", Convert.ToInt32(textBox7.Text));
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT into fatura(Fatura_No,Ad_Soyadi,Adres,Kdv,Fatura_Tarihi,Son_Odem_Tarihi,Odenecek_Tutar) VALUES(@FaturaNumarasi,'" + textBox2.Text + "','" + textBox3.Text + "',@KDVsi,'" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "',@Tutar) ";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            dt.Clear();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            komut.Parameters.AddWithValue("@FaturaNumarasi", Convert.ToInt32(textBox1.Text));
            DialogResult cvp = MessageBox.Show("EMİN MİSİN??", "Uyarı", MessageBoxButtons.YesNo);
            if (cvp == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE from fatura Where Fatura_No=@FaturaNumarasi";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                dt.Clear();
                listele();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            komut.Parameters.AddWithValue("@FaturaNumarasi",Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@KDVsi", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@Tutar", Convert.ToInt32(textBox7.Text));

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "UPDATE fatura SET Ad_Soyadi='" + textBox2.Text + "', Adres='" + textBox3.Text + "', Kdv=@KDVsi,Fatura_Tarihi='" + dateTimePicker1.Text + "', Son_Odem_Tarihi='" + dateTimePicker2.Text + "', Odenecek_Tutar=@Tutar Where Fatura_No=@FaturaNumarasi";
             komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
        }
    }
}
