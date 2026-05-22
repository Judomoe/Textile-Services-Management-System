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
    public partial class Form6 : Form
    {
        //private LinkedList<Customer> customerslist = new LinkedList<Customer>();
        //public static List<Customer> customerlist = new List<Customer>();
        private bool Gen;
        private int ag;
        private string nam;
        private string pass;
        private string addr;
        private string cit;
        public void getInfo()
        {
            nam = maskedTextBox1.Text;
            pass = textBox1.Text;
            ag = Convert.ToInt32(numericUpDown1.Value);
            cit=textBox2.Text;
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_FontChanged(object sender, EventArgs e)
        {
            //Customer cus1 = new Customer(maskedTextBox1.Text,);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Customer cus1 = new Customer(maskedTextBox1.Text, textBox1.Text, textBox2.Text);

            //this.Hide();
            //(new Form7()).ShowDialog();
            //listBox1.Items.Add(cus1.Name);
            //listBox1.Items.Add(cus1.Address);
            button1.Hide();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maskedTextBox1.Text)&&!string.IsNullOrEmpty(textBox1.Text)&&!string.IsNullOrEmpty(textBox2.Text))
            {
                getInfo();
                //customerlist.Add(new Customer(nam, ag, pass, Gen, 0, "fera5"));
                Customer cust = new Customer(nam, ag, pass, Gen, ag, cit);
                login login = new login(this, cust);
                cust.AddCustomer(cust);
                maskedTextBox1.Clear();
                textBox1.Clear();
                numericUpDown1.Value = 0;
                this.Hide();
                (new login()).Show();
            }
            else
            {
                MessageBox.Show("U should enter a value");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new login()).Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
