namespace TP_MODUL3_103022430015
{
    public partial class Form1 : Form
    {
        double angkaPertama = 0;
        string operasi = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            labelOutput.Text += btn.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            angkaPertama = double.Parse(labelOutput.Text);
            operasi = "+";
            labelOutput.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double angkaKedua = double.Parse(labelOutput.Text);
            double hasil = 0;

            if (operasi == "+")
            {
                hasil = angkaPertama + angkaKedua;
            }

            labelOutput.Text = hasil.ToString();
        }
    }
}
