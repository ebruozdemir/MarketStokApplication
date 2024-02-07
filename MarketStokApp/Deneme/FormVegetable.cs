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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Deneme
{
    public partial class FormVegetable : Form
    {
        public FormVegetable()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormVegetable_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("select * from Product where barcodeno = '500621'", baglanti);
            SqlDataReader read12 = komut12.ExecuteReader();
            while (read12.Read())
            {
                label21.Text = read12["salepri"].ToString();
                label2.Text = read12["productname"].ToString();
            }
            read12.Close();

            SqlCommand komut13 = new SqlCommand("select * from Product where barcodeno = '500612'", baglanti);
            SqlDataReader read13 = komut13.ExecuteReader();
            while (read13.Read())
            {
                label22.Text = read13["salepri"].ToString();
                label3.Text = read13["productname"].ToString();
            }
            read13.Close();

            SqlCommand komut14 = new SqlCommand("select * from Product where barcodeno = '500610'", baglanti);
            SqlDataReader read14 = komut14.ExecuteReader();
            while (read14.Read())
            {
                label23.Text = read14["salepri"].ToString();
                label4.Text = read14["productname"].ToString();
            }
            read14.Close();

            SqlCommand komut15 = new SqlCommand("select * from Product where barcodeno = '500678'", baglanti);
            SqlDataReader read15 = komut15.ExecuteReader();
            while (read15.Read())
            {
                label24.Text = read15["salepri"].ToString();
                label5.Text = read15["productname"].ToString();
            }
            read15.Close();

            SqlCommand komut16 = new SqlCommand("select * from Product where barcodeno = '500692'", baglanti);
            SqlDataReader read16 = komut16.ExecuteReader();
            while (read16.Read())
            {
                label25.Text = read16["salepri"].ToString();
                label6.Text = read16["productname"].ToString();
            }
            read16.Close();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                baglanti.Open();
               
                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
                komut.Parameters.AddWithValue("@productname", label2.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label21.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox1.Text));
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
                komut.Parameters.AddWithValue("@productname", label3.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label22.Text));
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
                komut.Parameters.AddWithValue("@salepri", double.Parse(label23.Text));
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
                komut.Parameters.AddWithValue("@salepri", double.Parse(label24.Text));
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
                komut.Parameters.AddWithValue("@salepri", double.Parse(label25.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox5.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product has been added into cart!");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            FormCategories categories = new FormCategories();
            this.Hide();
            categories.ShowDialog();
        }
    }
}
