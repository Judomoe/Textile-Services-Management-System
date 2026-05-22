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

    public partial class press_clean : Form
    {
        //private LinkedList<CleanOrder> cleaninglist = new LinkedList<CleanOrder>();
        Form3 form3instance;
        private int bantalon_;
        private int t_shirt_;
        private int dress_;
        public void getInfo()
        {
            bantalon_ = Convert.ToInt32(numericUpDown2.Value);
            t_shirt_ = Convert.ToInt32(numericUpDown1.Value);
            bantalon_ = Convert.ToInt32(numericUpDown3.Value);
        }
        public press_clean()
        {
            InitializeComponent();
        }
        public press_clean(Form3 ff)
        {
            InitializeComponent();
            form3instance = ff;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            Total.Text = calculator.total2(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form4(form3instance,0)).Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            Total.Text = calculator.total2(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            Total.Text = calculator.total2(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInfo();
            form3instance.kemeyetbantalon3=(int)numericUpDown2.Value;
            form3instance.kemeyettshirt3 = (int)numericUpDown1.Value;
            form3instance.kemeyetdress3 = (int)numericUpDown3.Value;
            //cleaninglist.AddLast(new CleanOrder(bantalon_, t_shirt_, dress_, 5, 10, 25));
            CleanOrder cleanInstance=new CleanOrder(bantalon_, t_shirt_, dress_);
            (cleanInstance).AddClean(cleanInstance);
            this.Hide();
            (new Form4(form3instance, int.Parse(Total.Text))).Show();
        }
    }
}
