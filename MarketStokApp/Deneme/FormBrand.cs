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
    public partial class FormBrand : Form
    {
        public FormBrand()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        bool durum;
        private void markaengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from BrandInfo", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text == read["category"].ToString() && textBox1.Text == read["brand"].ToString() || comboBox1.Text == "" || textBox1.Text == "")
                {
                    durum = false;
                }

            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            markaengelle();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into BrandInfo(category,brand) values ('" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Brand has been added successfully!");
            }
            else
            {
                MessageBox.Show("This category and brand already exist!", "Warning");
            }
            textBox1.Text = "";
            comboBox1.Text = "";

        
    }

        private void FormBrand_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from CategoryInfo", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["category"].ToString());
            }
            baglanti.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormStokPage stok = new FormStokPage();
            this.Hide();
            stok.ShowDialog();
        }
    }
}

