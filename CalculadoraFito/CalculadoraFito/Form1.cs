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
            int x = int.Parse(N3.Text);
            int y = int.Parse(N4.Text);
            int resultado = x - y;
            R2.Text = resultado.ToString();
        }

        private void N4_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N5.Text);
            int y = int.Parse(N6.Text);
            int resultado = x * y;
            R3.Text = resultado.ToString();
        }

        private void equals4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N7.Text);
            int y = int.Parse(N8.Text);
            int resultado = x / y;
            R4.Text = resultado.ToString();
        }

        private void equals5_Click(object sender, EventArgs e)
        {
            double x = double.Parse(N9.Text);
            double y = double.Parse(N10.Text);
            double resultado = Math.Pow(x, y);
            R6.Text = resultado.ToString();
        }

        private void equals6_Click(object sender, EventArgs e)
        {
            double x = double.Parse(N11.Text);
            double resultado = Math.Pow(x, 1.0/2.0);
            R7.Text = resultado.ToString();
        }

        private void equals7_Click(object sender, EventArgs e)
        {
            double x = double.Parse(N12.Text);
            double resultado = Math.Pow(x, 1.0 / 3.0);
            R8.Text = resultado.ToString();
        }
    }
}