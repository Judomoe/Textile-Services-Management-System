namespace tagroba1
{
    partial class login
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button5 = new Button();
            confirm = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(115, 65);
            label1.Name = "label1";
            label1.Size = new Size(557, 41);
            label1.TabIndex = 0;
            label1.Text = "Please enter your name and password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(198, 148);
            label2.Name = "label2";
            label2.Size = new Size(118, 31);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(201, 203);
            label3.Name = "label3";
            label3.Size = new Size(115, 31);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(358, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 27);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(248, 283);
            label4.Name = "label4";
            label4.Size = new Size(254, 28);
            label4.TabIndex = 5;
            label4.Text = "if you dont have an account";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(508, 283);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 28);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Algerian", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(115, 334);
            button5.Name = "button5";
            button5.Size = new Size(170, 54);
            button5.TabIndex = 23;
            button5.Text = "BACK";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // confirm
            // 
            confirm.Cursor = Cursors.Hand;
            confirm.Font = new Font("Algerian", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            confirm.Location = new Point(486, 334);
            confirm.Name = "confirm";
            confirm.Size = new Size(186, 54);
            confirm.TabIndex = 37;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(248, 252);
            label5.Name = "label5";
            label5.Size = new Size(333, 20);
            label5.TabIndex = 38;
            label5.Text = "The user name and the password does not match";
            label5.Visible = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(confirm);
            Controls.Add(button5);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private LinkLabel linkLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button5;
        private Button confirm;
        private Label label5;
    }
}