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
    public partial class Form3 : Form
    {
        public int kemeyetbantalon, kemeyettshirt, kemeyetdress, kemeyetbantalon2, kemeyettshirt2, kemeyetdress2, kemeyetbantalon3, kemeyettshirt3, kemeyetdress3;
        private int i = 0;
        public Form3()
        {
            InitializeComponent();
        }
        public void AddTask(int x, int y, int z)
        {
            i += 1;
            checkedListBox1.Items.Add("order" + i + "\tbantalonat=" + Convert.ToString(kemeyetbantalon) + "\ttshirtat=" + kemeyettshirt + "\tdress=" + kemeyetdress);
        }
        public Form3(int kemeyetbantalon, int kemeyettshirt, int kemeyetdress, int kemeyetbantalon2, int kemeyettshirt2, int kemeyetdress2, int kemeyetbantalon3, int kemeyettshirt3, int kemeyetdress3)
        {
            InitializeComponent();
            this.kemeyetbantalon = kemeyetbantalon;
            this.kemeyettshirt = kemeyettshirt;
            this.kemeyetdress = kemeyetdress;
            this.kemeyetbantalon2 = kemeyetbantalon2;
            this.kemeyettshirt2 = kemeyettshirt2;
            this.kemeyetdress2 = kemeyetdress2;
            this.kemeyetbantalon3 = kemeyetbantalon3;
            this.kemeyettshirt3 = kemeyettshirt3;
            this.kemeyetdress3 = kemeyetdress3;
            i += 1;
            checkedListBox1.Items.Add("order" + i + "\tbantalonat=" + kemeyetbantalon + "\ttshirtat=" + kemeyettshirt + "\tdress=" + kemeyetdress);
            checkedListBox2.Items.Add("order" + i + "\tbantalonat=" + kemeyetbantalon2 + "\ttshirtat=" + kemeyettshirt2 + "\tdress=" + kemeyetdress2);
            checkedListBox3.Items.Add("order" + i + "\tbantalonat=" + kemeyetbantalon3 + "\ttshirtat=" + kemeyettshirt3 + "\tdress=" + kemeyetdress3);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Wash_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Employee_log()).ShowDialog();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox1.Text = "gg";
            checkedListBox1.Items.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            i += 1;
            AddTask(kemeyetbantalon, kemeyettshirt, kemeyetdress);
            //checkedListBox1.Items.Add("order=" + i + "\tbantalonat=" + kemeyetbantalon + "\ttshirtat=" + kemeyettshirt + "\tdress=" + kemeyetdress);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new secret()).Show();
        }
    }
}
