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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Deneme
{
    public partial class FormUserLogin : Form
    {
        public FormUserLogin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelSignUp_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from musteriekle where email='" + textBoxUserName.Text + "'and password='" + textBoxPassword.Text + "'", baglanti);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                FormCategories categorypage = new FormCategories();
                this.Hide();
                categorypage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password incorrect!");
            }
            baglanti.Close();

           
        }





        private void labelSignUp_Click(object sender, EventArgs e)
        {
            FormSignUpUser signup = new FormSignUpUser();
            this.Hide();
            signup.ShowDialog();
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            this.Hide();
            main.ShowDialog();
        }
    }
}
