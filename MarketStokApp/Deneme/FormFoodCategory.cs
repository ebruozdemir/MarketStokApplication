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
    public partial class FormFoodCategory : Form
    {
        public FormFoodCategory()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormFoodCategory_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select salepri,productname from Product where barcodeno = '500671'", baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                label5.Text = read2["salepri"].ToString() ;
                label4.Text = read2["productname"].ToString();
            }
            read2.Close();


            SqlCommand komut3 = new SqlCommand("select salepri,productname from Product where barcodeno = '500651'", baglanti);
            SqlDataReader read3 = komut3.ExecuteReader();
            while (read3.Read())
            {
                label6.Text = read3["salepri"].ToString();
                label7.Text = read3["productname"].ToString();
            }
            read3.Close();

            SqlCommand komut4 = new SqlCommand("select salepri,productname from Product where barcodeno = '500683'", baglanti);
            SqlDataReader read4 = komut4.ExecuteReader();
            while (read4.Read())
            {
                label13.Text = read4["salepri"].ToString();
                label8.Text = read4["productname"].ToString();
            }
            read4.Close();

            SqlCommand komut5 = new SqlCommand("select salepri ,productname from Product where barcodeno = '500693'", baglanti);
            SqlDataReader read5 = komut5.ExecuteReader();
            while (read5.Read())
            {
                label14.Text = read5["salepri"].ToString() ;
                label9.Text = read5["productname"].ToString();
            }
            read5.Close();

            SqlCommand komut6 = new SqlCommand("select salepri,productname from Product where barcodeno = '500615'", baglanti);
            SqlDataReader read6 = komut6.ExecuteReader();
            while (read6.Read())
            {
                label15.Text = read6["salepri"].ToString() ;
                label10.Text = read6["productname"].ToString();
            }
            read6.Close();

            baglanti.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
                komut.Parameters.AddWithValue("@productname", label4.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label5.Text));
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
                komut.Parameters.AddWithValue("@productname", label7.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label6.Text));
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
                komut.Parameters.AddWithValue("@productname", label8.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label13.Text));
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
                komut.Parameters.AddWithValue("@productname", label9.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label14.Text));
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
                komut.Parameters.AddWithValue("@productname", label10.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label15.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox5.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added into cart!");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            FormShoppinCart cart = new FormShoppinCart();
            this.Hide();
            cart.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            FormCategories category = new FormCategories();
            this.Hide();
            category.ShowDialog();
        }
    }
}
