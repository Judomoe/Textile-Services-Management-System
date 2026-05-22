namespace tagroba1
{
    partial class Press
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
            numericUpDown3 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            button5 = new Button();
            label7 = new Label();
            confirm = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 74);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "bantalon";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 125);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "T-shirt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 185);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 4;
            label3.Text = "Dress";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(195, 178);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(259, 27);
            numericUpDown3.TabIndex = 5;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 185);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 6;
            label4.Text = "50 $";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 123);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 8;
            label5.Text = "15 $";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(195, 125);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(259, 27);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 81);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 10;
            label6.Text = "10 $";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(195, 74);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(259, 27);
            numericUpDown2.TabIndex = 9;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Algerian", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(27, 246);
            button5.Name = "button5";
            button5.Size = new Size(143, 41);
            button5.TabIndex = 11;
            button5.Text = "BACK";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(404, 19);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 12;
            label7.Text = "0";
            label7.Click += label7_Click;
            // 
            // confirm
            // 
            confirm.Cursor = Cursors.Hand;
            confirm.Font = new Font("Algerian", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            confirm.Location = new Point(268, 246);
            confirm.Name = "confirm";
            confirm.Size = new Size(186, 41);
            confirm.TabIndex = 36;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(334, 14);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 37;
            label9.Text = "Total";
            // 
            // Press
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 299);
            Controls.Add(label9);
            Controls.Add(confirm);
            Controls.Add(label7);
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
            Name = "Press";
            Text = "Press";
            Load += Press_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private Button button5;
        private Label label7;
        private Button confirm;
        private Button button1;
        private Label label8;
        private Label label9;
    }
}