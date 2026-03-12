using System.Security.Cryptography.X509Certificates;

namespace Exercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }



        private void Converter_Click(object sender, EventArgs e)

        {
            double c,f, Resultado;
            Console.WriteLine();
            c = Convert.ToDouble(Console.ReadLine());
            f = c * 9 / 5 + 32;

            txtFA.Text = f.ToString();

        }

}   }       