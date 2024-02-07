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
    public partial class FormJunkFood : Form
    {
        public FormJunkFood()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");

        private void FormJunkFood_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Product where barcodeno = '500611'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                l1.Text = read["salepri"].ToString() ;
                label3.Text = read["productname"].ToString();
            }
            read.Close();
            SqlCommand komut17 = new SqlCommand("select * from Product where barcodeno = '500631'", baglanti);
            SqlDataReader read17 = komut17.ExecuteReader();
            while (read17.Read())
            {
                label26.Text = read17["salepri"].ToString() ;
                label1.Text = read17["productname"].ToString();
            }
            read17.Close();

            SqlCommand komut18 = new SqlCommand("select * from Product where barcodeno = '500633'", baglanti);
            SqlDataReader read18 = komut18.ExecuteReader();
            while (read18.Read())
            {
                label27.Text = read18["salepri"].ToString() ;
                label2.Text = read18["productname"].ToString();
            }
            read18.Close();


            SqlCommand komut20 = new SqlCommand("select * from Product where barcodeno = '500605'", baglanti);
            SqlDataReader read20 = komut20.ExecuteReader();
            while (read20.Read())
            {
                label28.Text = read20["salepri"].ToString() ;
                label5.Text = read20["productname"].ToString();
            }
            read20.Close();
            baglanti.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Cart (productname,salepri,amount) values(@productname,@salepri,@amount)", baglanti);
               
                komut.Parameters.AddWithValue("@productname", label1.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label26.Text));
                komut.Parameters.AddWithValue("@amount",int.Parse(textBox1.Text));
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
               
                komut.Parameters.AddWithValue("@productname", label2.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(label27.Text));
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
              
                komut.Parameters.AddWithValue("@productname", label3.Text);
                komut.Parameters.AddWithValue("@salepri", double.Parse(l1.Text));
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
                komut.Parameters.AddWithValue("@salepri", double.Parse(label28.Text));
                komut.Parameters.AddWithValue("@amount", int.Parse(textBox4.Text));
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

        private void label16_Click(object sender, EventArgs e)
        {
            FormCategories categories=new FormCategories();
            this.Hide();
            categories.ShowDialog();

        }
    }
}
