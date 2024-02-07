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
    public partial class FormBeverageCategory : Form
    {
        public FormBeverageCategory()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");


        private void FormBeverageCategory_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Product where barcodeno = '500680'", baglanti);
            SqlDataReader read7 = komut7.ExecuteReader();
            while (read7.Read())
            {
                label16.Text = read7["salepri"].ToString() ;
                label2.Text = read7["productname"].ToString();
            }
            read7.Close();

            SqlCommand komut8 = new SqlCommand("select *from Product where barcodeno = '500694'", baglanti);
            SqlDataReader read8 = komut8.ExecuteReader();
            while (read8.Read())
            {
                label17.Text = read8["salepri"].ToString();
                label3.Text = read8["productname"].ToString();
            }
            read8.Close();

            SqlCommand komut9 = new SqlCommand("select * from Product where barcodeno = '500662'", baglanti);
            SqlDataReader read9 = komut9.ExecuteReader();
            while (read9.Read())
            {
                label18.Text = read9["salepri"].ToString();
                label4.Text = read9["productname"].ToString();
            }
            read9.Close();

            SqlCommand komut10 = new SqlCommand("select * from Product where barcodeno = '500664'", baglanti);
            SqlDataReader read10 = komut10.ExecuteReader();
            while (read10.Read())
            {
                label19.Text = read10["salepri"].ToString();
                label5.Text = read10["productname"].ToString();
            }
            read10.Close();

            SqlCommand komut11 = new SqlCommand("select * from Product where barcodeno = '500641'", baglanti);
            SqlDataReader read11 = komut11.ExecuteReader();
            while (read11.Read())
            {
                label20.Text = read11["salepri"].ToString();
                label6.Text = read11["productname"].ToString();
            }
            read11.Close();
            baglanti.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
                komut.Parameters.AddWithValue("@productname", label2.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label16.Text));
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
                komut.Parameters.AddWithValue("@salepri", double.Parse(label17.Text));
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
                komut.Parameters.AddWithValue("@salepri", double.Parse(label18.Text));
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
                komut.Parameters.AddWithValue("@salepri", double.Parse(label19.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox4.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added into cart!");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
            
                komut.Parameters.AddWithValue("@productname", label6.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label20.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox5.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added into cart!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormShoppinCart cart = new FormShoppinCart();
            this.Hide();
            cart.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormCategories categories = new FormCategories();
            this.Hide();
            categories.ShowDialog();
        }
    }
}
