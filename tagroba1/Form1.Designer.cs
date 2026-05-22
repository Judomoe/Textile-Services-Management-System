namespace tagroba1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            butto = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butto
            // 
            butto.BackColor = Color.LimeGreen;
            butto.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            butto.ForeColor = SystemColors.ButtonHighlight;
            butto.Location = new Point(85, 210);
            butto.Name = "butto";
            butto.Size = new Size(181, 94);
            butto.TabIndex = 0;
            butto.Text = "Customer";
            butto.UseVisualStyleBackColor = false;
            butto.Click += butto_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(445, 210);
            button2.Name = "button2";
            button2.Size = new Size(172, 94);
            button2.TabIndex = 1;
            button2.Text = "Employee";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 127);
            label1.Name = "label1";
            label1.Size = new Size(212, 37);
            label1.TabIndex = 2;
            label1.Text = "What are u?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 40);
            label2.Name = "label2";
            label2.Size = new Size(497, 50);
            label2.TabIndex = 3;
            label2.Text = "Welcome to makwagi";
            label2.Click += label2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Makwajy_logo;
            pictureBox1.Location = new Point(600, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(708, 420);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(butto);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butto;
        private Button button2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
