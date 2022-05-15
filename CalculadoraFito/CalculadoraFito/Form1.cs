namespace CalculadoraFito
{
    public partial class R5 : Form
    {
        public R5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void equals1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N1.Text);
            int y = int.Parse(N2.Text);
            int resultado = x + y;
            R1.Text = resultado.ToString();
        }

        private void equals2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N1.Text);
            int y = int.Parse(N2.Text);
            int resultado = x - y;
            R1.Text = resultado.ToString();
        }

        private void N4_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N1.Text);
            int y = int.Parse(N2.Text);
            int resultado = x * y;
            R1.Text = resultado.ToString();
        }

        private void equals4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N1.Text);
            int y = int.Parse(N2.Text);
            int resultado = x / y;
            R1.Text = resultado.ToString();
        }

        private void equals5_Click(object sender, EventArgs e)
        {
            double x = double.Parse(N1.Text);
            double y = double.Parse(N2.Text);
            double resultado = Math.Pow(x, y);
            R1.Text = resultado.ToString();
        }

        private void equals6_Click(object sender, EventArgs e)
        {
            double x = double.Parse(N3.Text);
            double resultado = Math.Pow(x, 1.0/2.0);
            R2.Text = resultado.ToString();
        }

        private void equals7_Click(object sender, EventArgs e)
        {
            double x = double.Parse(N3.Text);
            double resultado = Math.Pow(x, 1.0 / 3.0);
            R2.Text = resultado.ToString();
        }

        private void equals8_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N4.Text);
            if(x % 2 == 0)
            {
                R3.Text = "Par";
            }
            else
            {
                R3.Text = "Impar";
            }
        }
    }
}