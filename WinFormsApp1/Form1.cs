namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Converter_Click(object sender, EventArgs e)
        {
            int R, D,Resultado;

            D = Convert.ToInt32(txtDolar.Text);
            R = Convert.ToInt32(txtDolar.Text);
            Resultado = D * 6;
            txtReal.Text = Resultado.ToString();
            
        }
    }
    
}
