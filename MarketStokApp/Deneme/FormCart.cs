using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Deneme
{
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        DataSet daset = new DataSet();


       
        private void FormCart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketStokDataSet.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.marketStokDataSet.Cart);

            baglanti.Open();
            /*
            SqlDataAdapter adtr = new SqlDataAdapter("select *from ShopCart", baglanti);
            adtr.Fill(daset, "ShopCart");
            dataGridView1.DataSource = daset.Tables["ShopCart"];*/

          

            SqlCommand komut = new SqlCommand("select productname,salepri,amount from Cart", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                listBox1.Items.Add(read["salepri"].ToString() + " \t " + (read["amount"].ToString()) + " adet" +"\t"+ (read["productname"].ToString()));


            }
            read.Close();
            SqlCommand komut2 = new SqlCommand("SELECT sum(salepri*amount) FROM Cart", baglanti);
            

            lt.Text = komut2.ExecuteScalar().ToString();

            baglanti.Close();


        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            listBox1.Items.Remove(listBox1.SelectedItem);

            /*
            foreach (char i in listBox1.Items.Count.ToString())
            {
                //SqlCommand komut = new SqlCommand("delete from Cart where productname " + i, baglanti);
                Console.WriteLine(i);
            }
            */
            MessageBox.Show("Product has been deleted successfully");
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Cart", baglanti);
            komut.ExecuteNonQuery();
           
            listBox1.Items.Clear();
            MessageBox.Show("Your shop cart has been deleted successfully");
            SqlCommand komut2 = new SqlCommand("select sum(salepri*amount) from Cart ", baglanti);
            lt.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
        }

        private void labeltotal_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormMain main=new FormMain();
            this.Hide();
            main.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormCategories categories=new FormCategories();
            this.Hide();
            categories.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MessageBox.Show("Selling process has been succesfully!");
            SqlCommand komut = new SqlCommand("insert into Cart2(productname,amount,salepri) values(@productname,@amount,@salepri)", baglanti);
            komut.ExecuteNonQuery();
            listBox1.Items.Clear();
            baglanti.Close();
        }
    }
}
