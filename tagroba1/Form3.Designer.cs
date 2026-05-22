namespace tagroba1
{
    partial class Form3
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
            tabControl1 = new TabControl();
            Press = new TabPage();
            checkedListBox1 = new CheckedListBox();
            Wash = new TabPage();
            checkedListBox2 = new CheckedListBox();
            Knit = new TabPage();
            checkedListBox3 = new CheckedListBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            Press.SuspendLayout();
            Wash.SuspendLayout();
            Knit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 24);
            label1.TabIndex = 3;
            label1.Text = "Hi";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Press);
            tabControl1.Controls.Add(Wash);
            tabControl1.Controls.Add(Knit);
            tabControl1.Location = new Point(31, 54);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(540, 294);
            tabControl1.TabIndex = 5;
            // 
            // Press
            // 
            Press.Controls.Add(checkedListBox1);
            Press.Location = new Point(4, 29);
            Press.Name = "Press";
            Press.Padding = new Padding(3);
            Press.Size = new Size(532, 261);
            Press.TabIndex = 1;
            Press.Text = "Press";
            Press.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(15, 14);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(511, 224);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
            // 
            // Wash
            // 
            Wash.Controls.Add(checkedListBox2);
            Wash.Location = new Point(4, 29);
            Wash.Name = "Wash";
            Wash.Padding = new Padding(3);
            Wash.Size = new Size(532, 261);
            Wash.TabIndex = 0;
            Wash.Text = "Wash";
            Wash.UseVisualStyleBackColor = true;
            Wash.Click += Wash_Click;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(6, 6);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(520, 246);
            checkedListBox2.TabIndex = 0;
            // 
            // Knit
            // 
            Knit.Controls.Add(checkedListBox3);
            Knit.Location = new Point(4, 29);
            Knit.Name = "Knit";
            Knit.Size = new Size(532, 261);
            Knit.TabIndex = 2;
            Knit.Text = "Knit";
            Knit.UseVisualStyleBackColor = true;
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Location = new Point(3, 3);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(517, 246);
            checkedListBox3.TabIndex = 0;
            checkedListBox3.SelectedIndexChanged += checkedListBox3_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Algerian", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(242, 354);
            button1.Name = "button1";
            button1.Size = new Size(143, 41);
            button1.TabIndex = 6;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Makwajy_logo;
            pictureBox1.Location = new Point(553, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(638, 404);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            tabControl1.ResumeLayout(false);
            Press.ResumeLayout(false);
            Wash.ResumeLayout(false);
            Knit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage Wash;
        private TabPage Press;
        private TabPage Knit;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private PictureBox pictureBox1;
    }
}