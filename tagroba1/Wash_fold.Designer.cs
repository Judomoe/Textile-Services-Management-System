namespace tagroba1
{
    partial class Wash_fold
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
            Total = new Label();
            button5 = new Button();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            numericUpDown3 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            confirm = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(448, 23);
            Total.Name = "Total";
            Total.Size = new Size(17, 20);
            Total.TabIndex = 34;
            Total.Text = "0";
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Algerian", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(64, 278);
            button5.Name = "button5";
            button5.Size = new Size(143, 41);
            button5.TabIndex = 33;
            button5.Text = "BACK";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(135, 144);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 32;
            label6.Text = "5 $";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(231, 78);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(259, 27);
            numericUpDown2.TabIndex = 31;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 85);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 30;
            label5.Text = "10 $";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(231, 137);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(259, 27);
            numericUpDown1.TabIndex = 29;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 199);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 28;
            label4.Text = "25 $";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(231, 192);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(259, 27);
            numericUpDown3.TabIndex = 27;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 199);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 26;
            label3.Text = "Dress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 144);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 25;
            label2.Text = "T-shirt";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 85);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 24;
            label1.Text = "bantalon";
            // 
            // confirm
            // 
            confirm.Cursor = Cursors.Hand;
            confirm.Font = new Font("Algerian", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            confirm.Location = new Point(304, 278);
            confirm.Name = "confirm";
            confirm.Size = new Size(186, 41);
            confirm.TabIndex = 36;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += button1_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(369, 19);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 38;
            label9.Text = "Total";
            // 
            // Wash_fold
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 355);
            Controls.Add(label9);
            Controls.Add(confirm);
            Controls.Add(Total);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(numericUpDown2);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(numericUpDown3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Wash_fold";
            Text = "Wash_fold";
            Load += Wash_fold_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Total;
        private Button button5;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private NumericUpDown numericUpDown3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button confirm;
        private Label label9;
    }
}