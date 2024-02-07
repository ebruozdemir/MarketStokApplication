using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FormFoodCategory food = new FormFoodCategory();
            this.Hide();
            food.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormBeverageCategory beverage = new FormBeverageCategory();
            this.Hide();
            beverage.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormVegetable vegetable = new FormVegetable();
            this.Hide();
            vegetable.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FormJunkFood junk = new FormJunkFood();
            this.Hide();
            junk.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FormToy toy = new FormToy();
            this.Hide();
            toy.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FormPersonalCare care = new FormPersonalCare();
            this.Hide();
            care.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
