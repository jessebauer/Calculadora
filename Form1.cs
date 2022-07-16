namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "0";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "5";
        }

        private void btncSeis_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "÷";
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "*";
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "-";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text = txtVisor.Text + "+";
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            string visorTemporario = txtVisor.Text;
            visorTemporario = visorTemporario.Remove(visorTemporario.Length - 1);
            txtVisor.Text = visorTemporario;
        }
    }
}