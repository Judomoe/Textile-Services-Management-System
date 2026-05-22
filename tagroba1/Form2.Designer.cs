namespace tagroba1
{
    partial class Employee_log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Algerian", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(177, 256);
            button1.Name = "button1";
            button1.Size = new Size(143, 41);
            button1.TabIndex = 1;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 66);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Employee ID:";
            label2.Click += label2_Click_1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(148, 63);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(146, 27);
            maskedTextBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 120);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(200, 158);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.Makwajy_logo;
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(45, 201);
            label4.Name = "label4";
            label4.Size = new Size(408, 28);
            label4.TabIndex = 8;
            label4.Text = "YOU DO NOT WORK HERE!!, WHO ARE U??!";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // Employee_log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(502, 309);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Employee_log";
            Text = "Employeewind";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label4;
    }
}