using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tagroba1
{
    public partial class login : Form
    {
        public static List<Customer> customersssslist = new List<Customer>();
        private Form6 form6;
        public login()
        {
            InitializeComponent();
        }
        public login(Form6 form6,Customer i)
        {
            InitializeComponent();
            customersssslist.Add(i);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            (new Form6()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form1()).Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (Customer.customerlist.Any(u => u.Name == textBox1.Text && u.Password == textBox2.Text))
            {
                this.Hide();
                (new Form4()).Show();
            }
            else { label5.Show(); 
                }
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
