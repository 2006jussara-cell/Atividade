namespace WinFormsApp1
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
            Dolar = new Label();
            Real = new Label();
            txtDolar = new TextBox();
            txtReal = new TextBox();
            Converter = new Button();
            SuspendLayout();
            // 
            // Dolar
            // 
            Dolar.AutoSize = true;
            Dolar.Location = new Point(36, 52);
            Dolar.Name = "Dolar";
            Dolar.Size = new Size(38, 15);
            Dolar.TabIndex = 0;
            Dolar.Text = "label1";
            // 
            // Real
            // 
            Real.AutoSize = true;
            Real.Location = new Point(221, 52);
            Real.Name = "Real";
            Real.Size = new Size(38, 15);
            Real.TabIndex = 1;
            Real.Text = "label2";
            // 
            // txtDolar
            // 
            txtDolar.AccessibleName = "txtDolar";
            txtDolar.Location = new Point(80, 52);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 2;
            // 
            // txtReal
            // 
            txtReal.AccessibleName = "txtReal";
            txtReal.Location = new Point(265, 52);
            txtReal.Name = "txtReal";
            txtReal.Size = new Size(100, 23);
            txtReal.TabIndex = 3;
            // 
            // Converter
            // 
            Converter.AccessibleName = "bntConverter";
            Converter.Location = new Point(164, 104);
            Converter.Name = "Converter";
            Converter.Size = new Size(75, 23);
            Converter.TabIndex = 4;
            Converter.Text = "button1";
            Converter.UseVisualStyleBackColor = true;
            Converter.Click += Converter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 155);
            Controls.Add(Converter);
            Controls.Add(txtReal);
            Controls.Add(txtDolar);
            Controls.Add(Real);
            Controls.Add(Dolar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Dolar;
        private Label Real;
        private TextBox txtDolar;
        private TextBox txtReal;
        private Button Converter;
    }
}
