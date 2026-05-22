namespace tagroba1
{
    public partial class Form1 : Form
    {
        Form3 form3instance = new Form3();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form3 ff)
        {
            InitializeComponent();
            this.form3instance = ff;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 form1=new Form1();
            this.Hide();
            // Employee_log Form2 = new Employee_log();
            (new Employee_log(form3instance)).Show(); // Hide Form2


        }

        private void butto_Click(object sender, EventArgs e)
        {
            //amda7 amada = new amda7();
            this.Hide();
            //Form4 form4= new Form4();
            (new login()).Show();
            //MessageBox.Show(amada.fera5());
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }
    }

}
