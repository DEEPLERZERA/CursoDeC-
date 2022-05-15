namespace CalculadoraFito2
{
    public partial class CalculadoraFito : Form
    {
        public CalculadoraFito()
        {
            InitializeComponent();
        }

        private void equas1_Click(object sender, EventArgs e)
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

        private void CalculadoraFito_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void equals6_Click(object sender, EventArgs e)
        {
            double x = double.Parse(N3.Text);
            double resultado = Math.Pow(x, 1.0 / 2.0);
            R2.Text = resultado.ToString();
        }

        private void equals7_Click(object sender, EventArgs e)
        {
            double x = double.Parse(N4.Text);
            double resultado = Math.Pow(x, 1.0 / 3.0);
            R3.Text = resultado.ToString();
        }

        private void equals8_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N5.Text);
            if(x % 2 == 0)
            {
                R4.Text = "Par";
            }
            else
            {
                R4.Text = "Impar";
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            N1.Text = "";
            N2.Text = "";
            N3.Text = "";
            N4.Text = "";
            N5.Text = "";
            R1.Text = "";
            R2.Text = "";
            R3.Text = "";
            R4.Text = "";
        }
    }
}