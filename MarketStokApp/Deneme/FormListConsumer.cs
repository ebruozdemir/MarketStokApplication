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

namespace Deneme
{
    public partial class FormListConsumer : Form
    {
        public FormListConsumer()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        DataSet daset = new DataSet();

        private void KayıtGöster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select consumerıd,name_surname,phone,email,gender,address from musteriekle", baglanti);
            adtr.Fill(daset, "musteriekle");
            dataGridView1.DataSource = daset.Tables["musteriekle"];
            baglanti.Close();

        }
        private void FormListConsumer_Load(object sender, EventArgs e)
        {
            KayıtGöster();
        }

        private void ConID_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select consumerıd,name_surname,phone,email,gender,address from musteriekle where consumerıd like '%" + ConID.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from musteriekle where consumerıd='" + dataGridView1.CurrentRow.Cells["consumerıd"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["musteriekle"].Clear();
            KayıtGöster();
            MessageBox.Show("Customer registration has been deleted successfully!");

        }

        private void textconıd_TextChanged(object sender, EventArgs e)
        {
            if (textconıd.Text == "")
            {
                textnamesurname.Text = "";
                maskedTextBoxPhone.Text = "";
                Email.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from musteriekle where consumerıd like'" + textconıd.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textnamesurname.Text = read["name_surname"].ToString();
                maskedTextBoxPhone.Text = read["phone"].ToString();
                Email.Text = read["email"].ToString();
            }
            baglanti.Close();
        }

        private void maskedTextBoxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            FormStokPage stok = new FormStokPage();
            this.Hide();
            stok.ShowDialog();
        }
    }
}



