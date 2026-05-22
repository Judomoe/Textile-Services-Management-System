using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tagroba1
{
    public partial class Wash_fold : Form
    {
        public Form3 form3instance;
        //private LinkedList<WashOrder> washinglist = new LinkedList<WashOrder>();
        private int bantalon_;
        private int t_shirt_;
        private int dress_;
        public void getInfo()
        {
            bantalon_ = Convert.ToInt32(numericUpDown2.Value);
            t_shirt_ = Convert.ToInt32(numericUpDown1.Value);
            bantalon_ = Convert.ToInt32(numericUpDown3.Value);
        }
        public Wash_fold()
        {
            InitializeComponent();
        }
        public Wash_fold(Form3 ff)
        {
            InitializeComponent();
            form3instance = ff;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Wash_fold_Load(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            Total.Text = calculator.total3(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            Total.Text = calculator.total3(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            Total.Text = calculator.total3(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form4(form3instance, 0)).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            getInfo();
            form3instance.kemeyetbantalon2 = Convert.ToInt32(numericUpDown2.Value);
            form3instance.kemeyettshirt2 = (int)numericUpDown1.Value;
            form3instance.kemeyetdress2 = (int)numericUpDown3.Value;
            WashOrder washInstance = new WashOrder(bantalon_, t_shirt_, dress_);
            washInstance.AddWash(washInstance);

            this.Hide();
            (new Form4(form3instance, int.Parse(Total.Text))).Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            Total.Text = calculator.total3(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));
        }
    }
}
