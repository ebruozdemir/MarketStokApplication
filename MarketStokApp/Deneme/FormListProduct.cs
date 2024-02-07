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
    public partial class FormListProduct : Form
    {
        public FormListProduct()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        DataSet daset = new DataSet();
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
        private void FormListProduct_Load(object sender, EventArgs e)
        {
            ürünListele();
            kategorigetir();

        }
        private void ürünListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Product ", baglanti);
            adtr.Fill(daset, "Product");
            dataGridView1.DataSource = daset.Tables["Product"];
            baglanti.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BarcodeNotext.Text = dataGridView1.CurrentRow.Cells["barcodeno"].Value.ToString();
            Categorytext.Text = dataGridView1.CurrentRow.Cells["category"].Value.ToString();
            Brandtext.Text = dataGridView1.CurrentRow.Cells["brand"].Value.ToString();
            ProdNameText.Text = dataGridView1.CurrentRow.Cells["productname"].Value.ToString();
            Amounttext.Text = dataGridView1.CurrentRow.Cells["amount"].Value.ToString();
            PurcPritext.Text = dataGridView1.CurrentRow.Cells["purchasepri"].Value.ToString();
            SalePritext.Text = dataGridView1.CurrentRow.Cells["salepri"].Value.ToString();
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Product set productname=@productname, amount=@amount, purchasepri=@purchasepri,salepri=@salepri where barcodeno=@barcodeno", baglanti);
            komut.Parameters.AddWithValue("@barcodeno", BarcodeNotext.Text);
            komut.Parameters.AddWithValue("@productname", ProdNameText.Text);
            komut.Parameters.AddWithValue("@amount", int.Parse(Amounttext.Text));
            komut.Parameters.AddWithValue("@purchasepri", double.Parse(PurcPritext.Text));
            komut.Parameters.AddWithValue("@salepri", double.Parse(SalePritext.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Product"].Clear();
            ürünListele();
            MessageBox.Show("Update process has been performed successfully!");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }

        }
        private void buttonBrandUpdate_Click(object sender, EventArgs e)
        {
            if (BarcodeNotext.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Product set category=@category, brand=@brand where barcodeno=@barcodeno", baglanti);
                komut.Parameters.AddWithValue("@barcodeno", BarcodeNotext.Text);
                komut.Parameters.AddWithValue("@category", comboBoxCategory.Text);
                komut.Parameters.AddWithValue("@brand", comboBoxBrand.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Update process has been performed successfully!");
                daset.Tables["Product"].Clear();
                ürünListele();

            }
            else
            {
                MessageBox.Show("You must enter barcode number!", "Warning");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";

                }
            }

        }
        
    
    private void buttonDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Product where barcodeno='" + dataGridView1.CurrentRow.Cells["barcodeno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Product"].Clear();
            ürünListele();
            MessageBox.Show("Product information has been deleted successfully!");
        }

        private void textSearchbarcodeno_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Product where barcodeno like '%" + textSearchbarcodeno.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            FormStokPage stok = new FormStokPage();
            this.Hide();
            stok.ShowDialog();
        }
    }
}
