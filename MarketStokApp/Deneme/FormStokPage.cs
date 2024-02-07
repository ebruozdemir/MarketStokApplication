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
    public partial class FormStokPage : Form
    {
        public FormStokPage()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            FormListConsumer listele = new FormListConsumer();
            this.Hide();
            listele.ShowDialog();
        }

        private void FormStokPage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCategory kategori = new FormCategory();
            this.Hide();
            kategori.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBrand marka = new FormBrand();
            this.Hide();
            marka.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAddProduct ekle = new FormAddProduct();
            this.Hide();
            ekle.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormBrand marka = new FormBrand();
            this.Hide();
            marka.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormListProduct listele = new FormListProduct();
            this.Hide();
            listele.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormListSales listele = new FormListSales();
            this.Hide();
            listele.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            this.Hide();
            main.ShowDialog();
        }
    }
}
