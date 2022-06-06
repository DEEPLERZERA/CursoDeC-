namespace Fibonnaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int novoNumero;
            int fibonacci;
            int termo = int.Parse(textBox2.Text);

            for(int i = int.Parse(textBox1.Text); i < termo; i++)
            {
                fibonacci = numeroAnterior + numeroAtual;
                textBox3.Text += (" '' ");
                textBox3.Text += (fibonacci.ToString());
                textBox3.Text += (" '' ");
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
        }
    }
}