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
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from AdminLogin where username='" + textBoxAdminUsername.Text + "'and password='" + textBoxAdminPassword.Text + "'", baglanti);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                FormStokPage stok = new FormStokPage();
                this.Hide();
                stok.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password incorrect!");
            }
            baglanti.Close();
            ;
            
        }

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            this.Hide();
            main.ShowDialog();
        }
    }
}
