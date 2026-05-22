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
    
    public partial class Form4 : Form
    {
        //public string Label2;
        Form3 form3instance=new Form3();
        public static int x=0;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form3 ff)
        {
            InitializeComponent();
            form3instance = ff;
        }
        public Form4(Form3 ff,int x)
        {
            InitializeComponent();
            form3instance = ff;
            Form4.x += x;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (form3instance == null)
            {
                MessageBox.Show("form3instancef is null.");
                return;
            }
            else
            {
                this.Hide();
                (new Press(form3instance, this)).Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            (new Form1(form3instance)).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            // lebel2.Text = "gg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new press_clean(form3instance)).Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Orders(form3instance,x)).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Wash_fold(form3instance)).Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
