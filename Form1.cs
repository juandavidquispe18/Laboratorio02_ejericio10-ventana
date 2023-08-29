namespace Laboratorio02_ejericio10_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double consumo, descuento, descuento01;
            consumo = Convert.ToDouble(textBox1.Text);
            if (consumo < 100)
            {
                descuento = consumo - (consumo * 0.10);
                descuento01 = descuento + (descuento * 0.18);
                MessageBox.Show("El monto total es: " + descuento01);
            }
        }
    }
}