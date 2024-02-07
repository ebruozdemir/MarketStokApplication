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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FJ04M73;Initial Catalog=MarketStok;Integrated Security=True");

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Value += 1;
                labelY.Text = guna2ProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                 FormMain main = new FormMain();
                 this.Hide();
                 main.ShowDialog();
                
               
            }

        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
