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
    public partial class Employee_log : Form
    {
        Form3 form3instance=new Form3();
        //private LinkedList<Employee> listofemployees=new LinkedList<Employee>();
        //private int sal;
        //private int hol;
        //private string nam;
        //private int age;
        //private string pass;
        //private bool gend;
        public Employee_log()
        {
            InitializeComponent();
        }
        public Employee_log(Form3 ff)
        {
            InitializeComponent();
            this.form3instance = ff;
        }
        //public void getInfo()
        //{
        //  nam = maskedTextBox1.Text;
        //pass=
        //}

        private void button1_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "221017764" && textBox1.Text == "1234")
            {
                this.Hide();
                Form3 form3 = new Form3(form3instance.kemeyetbantalon, form3instance.kemeyettshirt, form3instance.kemeyetdress, form3instance.kemeyetbantalon2, form3instance.kemeyettshirt2, form3instance.kemeyetdress2, form3instance.kemeyetbantalon3, form3instance.kemeyettshirt3, form3instance.kemeyetdress3);
                form3.Show();
            }
            else if (maskedTextBox1.Text == "221007608" && textBox1.Text == "12345")
            {
                this.Hide();
                Form3 form3 = new Form3(form3instance.kemeyetbantalon, form3instance.kemeyettshirt, form3instance.kemeyetdress, form3instance.kemeyetbantalon2, form3instance.kemeyettshirt2, form3instance.kemeyetdress2, form3instance.kemeyetbantalon3, form3instance.kemeyettshirt3, form3instance.kemeyetdress3);
                form3.Show();
            }
            else if (maskedTextBox1.Text == "221017636" && textBox1.Text == "123456")
            {
                this.Hide();
                Form3 form3 = new Form3(form3instance.kemeyetbantalon, form3instance.kemeyettshirt, form3instance.kemeyetdress, form3instance.kemeyetbantalon2, form3instance.kemeyettshirt2, form3instance.kemeyetdress2, form3instance.kemeyetbantalon3, form3instance.kemeyettshirt3, form3instance.kemeyetdress3);
                form3.Show();

            }
            else label4.Show();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
//......