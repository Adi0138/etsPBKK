using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Menu.Items.Add("Burger Daging");
            Menu.Items.Add("Burger Daging Keju");
            Menu.Items.Add("Burger Ayam");
            Menu.Items.Add("Burger Ayam Keju");
            Menu.Items.Add("Kebab");
            Menu.Items.Add("Kebab Extra Keju");
            Menu.Items.Add("Cireng Bumbu Rujak");
            Menu.Items.Add("Brown Sugar Boba");
            Menu.Items.Add("Lemon Squash");

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Menu.Text == "Burger Daging")
            {
                Price.Text = "Rp 10000";
            }
            else if (Menu.Text == "Burger Daging Keju")
            {
                Price.Text = "Rp 13000";
            }
            else if (Menu.Text == "Burger Ayam")
            {
                Price.Text = "Rp 8000";
            }
            else if (Menu.Text == "Burger Ayam Keju")
            {
                Price.Text = "Rp 11000";
            }
            else if (Menu.Text == "Kebab")
            {
                Price.Text = "Rp 13000";
            }
            else if (Menu.Text == "Kebab Extra Keju")
            {
                Price.Text = "Rp 15000";
            }
            else if (Menu.Text == "Cireng Bumbu Rujak")
            {
                Price.Text = "8000";
            }
            else if (Menu.Text == "Brown Sugar Boba")
            {
                Price.Text = "14000";
            }
            else if (Menu.Text == "Lemon Squash")
            {
                Price.Text = "9000";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MenuPrice.Text) && string.IsNullOrWhiteSpace(Price.Text))
            {
                MessageBox.Show("Choose menu first!");
            }
            else

            //MenuPrice.Items.Add("Menu" + " | " + " Price ");
            MenuPrice.Items.Add(Menu.Text + " = " + Price.Text);
            MenuPrice.Text = "";
            Menu.Text = "";
            Price.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrice.Items.Clear();
            //MenuPrice.Items.Add("Menu" + " | " + " Price ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Thank You!");
                this.Close();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                MessageBox.Show("Thank You!");
                this.Close();
            }
            else
            {

            }
        }
    }
    }

