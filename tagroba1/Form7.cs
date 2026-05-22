using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tagroba1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            //Form7 ffff=new Form7();
            //label1.Text = Customer.de7k[0].ToString();
            //label1.Text= new Customer(ffff.maskedTextBox1.Text, ffff.textBox1.Text, ffff.textBox2.Text);
        }
        public Form7(Customer customer)
        {
            InitializeComponent();
            label1.Text = customer.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
           //label1.Text = Customer.de7k[0].ToString();

        }
    }
}
