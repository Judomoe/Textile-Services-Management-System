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

    public partial class Press : Form
    {
        //private LinkedList<PressOrder> pressinglist = new LinkedList<PressOrder>();
        private int bantalon;
        private int T_shirt;
        private int dress;
        public Form3 form3instancef=new Form3();
        public Form4 form4instancef = new Form4();
        public void getInfo()
        {
            bantalon = Convert.ToInt32(numericUpDown2.Value);
            T_shirt = Convert.ToInt32(numericUpDown1.Value);
            dress = Convert.ToInt32(numericUpDown3.Value);

        }
        public static decimal de7k = 0;
        public Press()
        {
            InitializeComponent();
        }
        public Press(Form3 ff,Form4 fr)
        {
            InitializeComponent();
            form3instancef = ff;
            form4instancef = fr;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4Instance = new Form4();
            form4Instance.label2.Text = "$50";
            form4Instance.Show(); // Show the Form4 instance

        }


        public void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            label7.Text = calculator.total1(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4Instance = new Form4(form3instancef,0);
            form4Instance.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            label7.Text = calculator.total1(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            label7.Text = calculator.total1(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));
        }

        private void Press_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInfo();
            //pressinglist.AddLast(new PressOrder(bantalon, T_shirt, dress, 5, 10, 25));
            PressOrder pressInstance = new PressOrder(bantalon, T_shirt, dress);
            pressInstance.AddPress(pressInstance);
            if (form3instancef == null)
            {
                MessageBox.Show("form3instancef is null.");
                return;
            }
            else
            {
                form3instancef.kemeyetbantalon = (int)numericUpDown2.Value;
                form3instancef.kemeyettshirt = (int)numericUpDown1.Value;
                form3instancef.kemeyetdress = (int)numericUpDown3.Value;
            }
            //Form4.x += int.Parse(label7.Text);
            //new Form3((int)numericUpDown2.Value, (int)numericUpDown1.Value, (int)numericUpDown3.Value);
            //Form3 forminstance=new Form3((int)numericUpDown2.Value, (int)numericUpDown1.Value, (int)numericUpDown3.Value);
            this.Hide();
            //form4instancef.Show();
            (new Form4(form3instancef, int.Parse(label7.Text))).Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form3instancef.Show();
        }
    }
}
