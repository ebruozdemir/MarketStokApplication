using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class FormPersonalCare : Form
    {
        public FormPersonalCare()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");

        private void FormPersonalCare_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut25 = new SqlCommand("select * from Product where barcodeno = '500690'", baglanti);
            SqlDataReader read25 = komut25.ExecuteReader();
            while (read25.Read())
            {
                label33.Text = read25["salepri"].ToString() ;
                label2.Text = read25["productname"].ToString();
            }
            read25.Close();

            SqlCommand komut26 = new SqlCommand("select * from Product where barcodeno = '500681'", baglanti);
            SqlDataReader read26 = komut26.ExecuteReader();
            while (read26.Read())
            {
                label34.Text = read26["salepri"].ToString() ;
                label3.Text = read26["productname"].ToString();
            }
            read26.Close();




            baglanti.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
                komut.Parameters.AddWithValue("@productname", label2.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label33.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox1.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added into cart!");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
                komut.Parameters.AddWithValue("@productname", label3.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label34.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox2.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added into cart!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormShoppinCart cart = new FormShoppinCart();
            this.Hide();
            cart.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            FormCategories categories=new FormCategories();
            this.Hide();
            categories.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
