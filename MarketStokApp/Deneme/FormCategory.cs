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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        bool durum;
        private void kategoriengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from CategoryInfo", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["category"].ToString() || textBox1.Text == "")
                {
                    durum = false;
                }

            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into CategoryInfo(category) values ('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Category has been added successfully!");
            }
            else
            {
                MessageBox.Show("This category already exists!", "Warning");
            }
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCategory_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormStokPage stok = new FormStokPage();
            this.Hide();
            stok.ShowDialog();
        }
    }
}
