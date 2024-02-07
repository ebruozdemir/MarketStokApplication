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
    public partial class FormSignUpUser : Form
    {
        public FormSignUpUser()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");
        bool durum;
        private void emailkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriEkle", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBoxEmail.Text == read["email"].ToString() || textBoxEmail.Text == "")
                {
                    durum = false;
                }

            }
            baglanti.Close();
        }
        private void FormSignUpUser_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            emailkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into musteriekle (name_surname,phone,email,gender,address,password) values(@name_surname,@phone,@email,@gender,@address,@password)", baglanti);

                komut.Parameters.AddWithValue("@name_surname", textBoxNameSurname.Text);
                komut.Parameters.AddWithValue("@phone", maskedTextBoxPhone.Text);
                komut.Parameters.AddWithValue("@email", textBoxEmail.Text);
                komut.Parameters.AddWithValue("@gender", comboBoxGender.Text);
                komut.Parameters.AddWithValue("@address", textBoxAddress.Text);
                komut.Parameters.AddWithValue("@password", textBoxPassword.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Customer registration has been added successfully!");
            }

            else
            {
                MessageBox.Show("This membership already exists!", "Warning");
            }

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormUserLogin userlog = new FormUserLogin();
            this.Hide();
            userlog.ShowDialog();
        }
    }
}


          