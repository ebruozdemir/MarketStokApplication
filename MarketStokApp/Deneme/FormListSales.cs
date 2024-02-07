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
    public partial class FormListSales : Form
    {
        public FormListSales()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        DataSet daset = new DataSet();
        private void FormListSales_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Cart2", baglanti);
            adtr.Fill(daset, "Cart2");
            dataGridView1.DataSource = daset.Tables["Cart2"];

            SqlCommand komut = new SqlCommand("select sum(amount*salepri)from Cart2", baglanti);
            labelToplam.Text = komut.ExecuteScalar().ToString();
            komut.ExecuteNonQuery();
            baglanti.Close();



        }

        private void label15_Click(object sender, EventArgs e)
        {
            FormStokPage stok = new FormStokPage();
            this.Hide();
            stok.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
