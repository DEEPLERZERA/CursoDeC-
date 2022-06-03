namespace CalculadoraDePa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int razao = int.Parse(textBox2.Text);
            int termo = int.Parse(textBox1.Text);

            for(int posicao = int.Parse(textBox3.Text); posicao <= termo; posicao+= razao)
            {
                textBox4.Text += (" '' ");
                textBox4.Text += (posicao.ToString());
                textBox4.Text += (" '' ");

            }
        }
    }
}