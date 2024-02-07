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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Deneme
{
    public partial class FormToy : Form
    {
        public FormToy()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");

        private void FormToy_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut21 = new SqlCommand("select *from Product where barcodeno = '500606'", baglanti);
            SqlDataReader read21 = komut21.ExecuteReader();
            while (read21.Read())
            {
                label29.Text = read21["salepri"].ToString();
                label2.Text = read21["productname"].ToString();
            }
            read21.Close();

            SqlCommand komut22 = new SqlCommand("select * from Product where barcodeno = '500623'", baglanti);
            SqlDataReader read22 = komut22.ExecuteReader();
            while (read22.Read())
            {
                label30.Text = read22["salepri"].ToString() ;
                label3.Text = read22["productname"].ToString();
            }
            read22.Close();

            SqlCommand komut23 = new SqlCommand("select * from Product where barcodeno = '500614'", baglanti);
            SqlDataReader read23 = komut23.ExecuteReader();
            while (read23.Read())
            {
                label31.Text = read23["salepri"].ToString() ;
                label4.Text = read23["productname"].ToString();
            }
            read23.Close();


            SqlCommand komut24 = new SqlCommand("select * from Product where barcodeno = '500607'", baglanti);
            SqlDataReader read24 = komut24.ExecuteReader();
            while (read24.Read())
            {
                label32.Text = read24["salepri"].ToString();
                label5.Text = read24["productname"].ToString();
            }
            read24.Close();

            baglanti.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
                komut.Parameters.AddWithValue("@productname", label2.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label29.Text));
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
                komut.Parameters.AddWithValue("@salepri", double.Parse(label30.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox2.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added into cart!");
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
                komut.Parameters.AddWithValue("@productname", label4.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label31.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox3.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added into cart!");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
                komut.Parameters.AddWithValue("@productname", label5.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label32.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox4.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added into cart!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormShoppinCart cart = new FormShoppinCart();
            this.Hide();
            cart.ShowDialog();  
        }

        private void label16_Click(object sender, EventArgs e)
        {
            FormCategories categories = new FormCategories();
            this.Hide();
            categories.ShowDialog();    
        }
    }
}
