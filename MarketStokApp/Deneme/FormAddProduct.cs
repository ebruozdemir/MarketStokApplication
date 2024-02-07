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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Product", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBarcodeNo.Text == read["barcodeno"].ToString() || textBarcodeNo.Text == "")
                {
                    durum = false;
                }

            }
            baglanti.Close();
        }
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from CategoryInfo", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxCategory.Items.Add(read["category"].ToString());
            }
            baglanti.Close();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void buttonNewAdd_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Product (barcodeno,category,brand,productname,amount,purchasepri,salepri,history) values(@barcodeno,@category,@brand,@productname,@amount,@purchasepri,@salepri,@history)", baglanti);
                komut.Parameters.AddWithValue("@barcodeno", textBarcodeNo.Text);
                komut.Parameters.AddWithValue("@category", comboBoxCategory.Text);
                komut.Parameters.AddWithValue("@brand", comboBoxBrand.Text);
                komut.Parameters.AddWithValue("@productname", textBoxProdName.Text);
                komut.Parameters.AddWithValue("@amount", int.Parse(textBoxAmount.Text));
                komut.Parameters.AddWithValue("@purchasepri", double.Parse(textBoxPurcPri.Text));
                komut.Parameters.AddWithValue("@salepri", double.Parse(textBoxSalePri.Text));
                komut.Parameters.AddWithValue("@history", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added successfully!");

            }
            else
            {
                MessageBox.Show("This barcode number already exists!", "Warning");
            }

            comboBoxBrand.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBrand.Items.Clear();
            comboBoxBrand.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from BrandInfo where category='" + comboBoxCategory.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxBrand.Items.Add(read["brand"].ToString());
            }
            baglanti.Close();
        }

        private void BarcodeNotext_TextChanged(object sender, EventArgs e)
        {
            if (BarcodeNotext.Text == "")
            {
                labelAmount.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Product where barcodeno like '" + BarcodeNotext.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Categorytext.Text = read["category"].ToString();
                Brandtext.Text = read["brand"].ToString();
                ProdNameText.Text = read["productname"].ToString();
                labelAmount.Text = read["amount"].ToString();
                PurcPritext.Text = read["purchasepri"].ToString();
                SalePritext.Text = read["salepri"].ToString();


            }
            baglanti.Close();

        }

        private void buttonCurrentAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Product set Amount=Amount+'" + int.Parse(Amounttext.Text) + "'where barcodeno='" + BarcodeNotext.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
            MessageBox.Show("Addition has been maded to current product successfully!");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            FormStokPage stok = new FormStokPage();
            this.Hide();
            stok.ShowDialog();
        }
    }
}

