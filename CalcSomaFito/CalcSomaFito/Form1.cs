namespace CalcSomaFito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void somaButton_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N1.Text);
            int y = int.Parse(N2.Text);
            r.Text = (x + y).ToString();

            MessageBox.Show(x.ToString());
        }
    }
}