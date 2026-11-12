namespace task16_5a
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
            label1 = new Label();
            button1 = new Button();
            txtHour1 = new TextBox();
            txtMin1 = new TextBox();
            txtSec1 = new TextBox();
            txtHour2 = new TextBox();
            txtMin2 = new TextBox();
            txtSec2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(1, 180);
            label1.Name = "label1";
            label1.Size = new Size(537, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите два времени.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(229, 198);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Сравнить";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtHour1
            // 
            txtHour1.Location = new Point(150, 125);
            txtHour1.Name = "txtHour1";
            txtHour1.Size = new Size(74, 23);
            txtHour1.TabIndex = 2;
            txtHour1.TextChanged += txtHour1_TextChanged;
            // 
            // txtMin1
            // 
            txtMin1.Location = new Point(230, 125);
            txtMin1.Name = "txtMin1";
            txtMin1.Size = new Size(74, 23);
            txtMin1.TabIndex = 3;
            txtMin1.TextChanged += txtMin1_TextChanged;
            // 
            // txtSec1
            // 
            txtSec1.Location = new Point(310, 125);
            txtSec1.Name = "txtSec1";
            txtSec1.Size = new Size(74, 23);
            txtSec1.TabIndex = 4;
            txtSec1.TextChanged += txtSec1_TextChanged;
            // 
            // txtHour2
            // 
            txtHour2.Location = new Point(150, 154);
            txtHour2.Name = "txtHour2";
            txtHour2.Size = new Size(74, 23);
            txtHour2.TabIndex = 5;
            // 
            // txtMin2
            // 
            txtMin2.Location = new Point(230, 154);
            txtMin2.Name = "txtMin2";
            txtMin2.Size = new Size(74, 23);
            txtMin2.TabIndex = 6;
            // 
            // txtSec2
            // 
            txtSec2.Location = new Point(310, 154);
            txtSec2.Name = "txtSec2";
            txtSec2.Size = new Size(74, 23);
            txtSec2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 157);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 8;
            label2.Text = "t2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 128);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 9;
            label3.Text = "t1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 107);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 10;
            label4.Text = "hour";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 107);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 11;
            label5.Text = "min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 107);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 12;
            label6.Text = "sec";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 331);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSec2);
            Controls.Add(txtMin2);
            Controls.Add(txtHour2);
            Controls.Add(txtSec1);
            Controls.Add(txtMin1);
            Controls.Add(txtHour1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtHour1;
        private TextBox txtMin1;
        private TextBox txtSec1;
        private TextBox txtHour2;
        private TextBox txtMin2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtSec2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
