namespace lab6
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            tabPage3 = new TabPage();
            button3 = new Button();
            label6 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            tabPage4 = new TabPage();
            button4 = new Button();
            label8 = new Label();
            label7 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 449);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задание 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(272, 378);
            button1.Name = "button1";
            button1.Size = new Size(251, 23);
            button1.TabIndex = 4;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 195);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Результат:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 20);
            label1.Name = "label1";
            label1.Size = new Size(349, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите текст. Каждые два соседних слова поменяются места.";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(8, 213);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(776, 145);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(8, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 145);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задание 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(273, 378);
            button2.Name = "button2";
            button2.Size = new Size(251, 23);
            button2.TabIndex = 9;
            button2.Text = "Выполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 195);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 8;
            label4.Text = "Результат:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 20);
            label3.Name = "label3";
            label3.Size = new Size(455, 15);
            label3.TabIndex = 7;
            label3.Text = "Введите текст. Программа провирт и исправит сочетания жи, ши, ча, ща, чу, щу.";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(9, 213);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(776, 145);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(9, 38);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(776, 145);
            textBox3.TabIndex = 5;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(795, 421);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Задание 3";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(273, 378);
            button3.Name = "button3";
            button3.Size = new Size(251, 23);
            button3.TabIndex = 14;
            button3.Text = "Выполнить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 195);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 13;
            label6.Text = "Результат:";
            label6.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 20);
            label5.Name = "label5";
            label5.Size = new Size(498, 15);
            label5.TabIndex = 12;
            label5.Text = "Введите текст. Программа выведет строки, заканчивающиеся восклицательным знаком!";
            label5.Click += label6_Click;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(9, 213);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(776, 145);
            textBox6.TabIndex = 11;
            textBox6.TextChanged += textBox5_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(9, 38);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(776, 145);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox6_TextChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(textBox8);
            tabPage4.Controls.Add(textBox7);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(795, 421);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Задание 4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(273, 378);
            button4.Name = "button4";
            button4.Size = new Size(251, 23);
            button4.TabIndex = 14;
            button4.Text = "Выполнить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 195);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 13;
            label8.Text = "Результат:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 20);
            label7.Name = "label7";
            label7.Size = new Size(364, 15);
            label7.TabIndex = 12;
            label7.Text = "Введите текст. Фамилия И.О. - улица - дом - квартира - телефон.";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(9, 213);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(776, 145);
            textBox8.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(9, 38);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(776, 145);
            textBox7.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Label label4;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button3;
        private Label label6;
        private Label label5;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button4;
        private Label label8;
        private Label label7;
        private TextBox textBox8;
        private TextBox textBox7;
    }
}
