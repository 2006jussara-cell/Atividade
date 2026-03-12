namespace Exercicio12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            Converter = new Button();
            label2 = new Label();
            txtFA = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(171, 112);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 0;
            label1.Text = "Celsius C°";
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "txtC";
            textBox1.Location = new Point(250, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // Converter
            // 
            Converter.AccessibleName = "bntConverter";
            Converter.Font = new Font("Times New Roman", 12F);
            Converter.Location = new Point(213, 196);
            Converter.Name = "Converter";
            Converter.Size = new Size(75, 23);
            Converter.TabIndex = 2;
            Converter.Text = "Converter";
            Converter.UseVisualStyleBackColor = true;
            Converter.Click += Converter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 139);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // txtFA
            // 
            txtFA.AccessibleName = "txtF";
            txtFA.Location = new Point(250, 153);
            txtFA.Name = "txtFA";
            txtFA.Size = new Size(100, 23);
            txtFA.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(153, 157);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 5;
            label3.Text = "Fahrenheit F°";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(486, 330);
            Controls.Add(label3);
            Controls.Add(txtFA);
            Controls.Add(label2);
            Controls.Add(Converter);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button Converter;
        private Label label2;
        private TextBox txtFA;
        private Label label3;
    }
}
