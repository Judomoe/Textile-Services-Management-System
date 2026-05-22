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
    public partial class Orders : Form
    {
        Form3 form3instance = new Form3();
        int x;
        public Orders()
        {
            InitializeComponent();
        }
        public Orders(Form3 ff, int x)
        {
            InitializeComponent();
            form3instance = ff;
            this.x = x;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Form4(form3instance)).Show();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "number of pressed bantalons=" + Convert.ToString(form3instance.kemeyetbantalon) + "  number of pressed tshirts=" + Convert.ToString(form3instance.kemeyettshirt) + "  number of pressed dresses=" + Convert.ToString(form3instance.kemeyetdress);
            label7.Text = "number of cleaned bantalons=" + Convert.ToString(form3instance.kemeyetbantalon2) + "  number of cleaned tshirts=" + Convert.ToString(form3instance.kemeyettshirt2) + "  number of cleaned dresses=" + Convert.ToString(form3instance.kemeyetdress2);
            label8.Text = "number of washed bantalons=" + Convert.ToString(form3instance.kemeyetbantalon3) + "  number of washed tshirts=" + Convert.ToString(form3instance.kemeyettshirt3) + "  number of washed dresses=" + Convert.ToString(form3instance.kemeyetdress3);
            //label9.Text = (new Calculator()).total4(x, y, z);
            label5.Text = Convert.ToString(Form4.x);
            label10.Text = Convert.ToString(Form4.x+(Form4.x*(0.14)));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
