namespace laboratorna9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 30);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 80);
            textBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(30, 130);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Зчитувати з файлу";
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(10, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 24);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Математика";
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(10, 45);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Фізика";
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(10, 70);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(104, 24);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Програмування";
            // 
            // button1
            // 
            button1.Location = new Point(30, 270);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 3;
            button1.Text = "Обчислити";
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(30, 320);
            label1.Name = "label1";
            label1.Size = new Size(300, 100);
            label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(30, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Оберіть предмет";
            // 
            // Form1
            // 
            ClientSize = new Size(400, 450);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Середній бал студента";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}