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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Deneme
{
    public partial class FormShoppinCart : Form
    {
        public FormShoppinCart()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Cart", baglanti);
            adtr.Fill(daset, "Cart");
            dataGridView1.DataSource = daset.Tables["Cart"];



            baglanti.Close();

        }



        private void FormShoppinCart_Load(object sender, EventArgs e)
        {

            sepetListele();


            baglanti.Open();
           
            SqlCommand komut = new SqlCommand("select sum(salepri*amount) from Cart", baglanti);
            lt.Text = komut.ExecuteScalar() + " TL";

            baglanti.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Cart where productname='" + dataGridView1.CurrentRow.Cells["productname"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("select sum(salepri*amount) from Cart ", baglanti);
            lt.Text = komut2.ExecuteScalar().ToString();
            MessageBox.Show("Product has been deleted from the cart successfully!");
            daset.Tables["Cart"].Clear();
          
        
            baglanti.Close();

            sepetListele();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Cart ", baglanti);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("select sum(salepri*amount) from Cart ", baglanti);
            lt.Text = komut2.ExecuteScalar().ToString();

            MessageBox.Show("Product has been cancelled successfully!");
            daset.Tables["Cart"].Clear();
           
            baglanti.Close();

            sepetListele();
        }

        private void lt_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormCategories categories = new FormCategories();
            this.Hide();
            categories.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            this.Hide();
            main.ShowDialog();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MessageBox.Show("Selling process has been succesfully!");
            SqlCommand komut = new SqlCommand("insert into Cart2(productname,amount,salepri) select productname,amount,salepri from Cart", baglanti);
            
            komut.ExecuteNonQuery();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

               
               SqlCommand komut2 = new SqlCommand("update Product set amount=amount-'" + (int.Parse(dataGridView1.Rows[i].Cells["amount"].Value.ToString())) + "'where productname='" + (dataGridView1.Rows[i].Cells["productname"].Value.ToString()) + "'", baglanti);
                komut2.ExecuteNonQuery();
               
            }

            daset.Tables["Cart"].Clear();

            baglanti.Close();
        }
    }
}
