namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double operadorTemporario;
        int count;
        bool jaCalculou = false;
        double result;


        private void Form1_Load(EventArgs e, object sender)
        {

        }
        private void exibeTela(TextBox t, String s)
        {
            t.Text += s;
        }

        private void calcula()
        {
            try
            {
                result = double.Parse(txtTelaTemporaria.Text);
            } catch { };
            switch (count)
            {
                case 1:
                    result += operadorTemporario;
                    break;
                case 2:
                    result = -result + operadorTemporario;
                    break;
                case 3:
                    result *= operadorTemporario;
                    break;
                case 4:
                    result /= operadorTemporario;
                    break;
                case 5:
                    result = operadorTemporario * operadorTemporario;
                    break;
            }
            jaCalculou = true;
            txtTelaTemporaria.Text = null;
            txtVisor.Text = $"{result}";
            operadorTemporario = double.Parse(txtVisor.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTelaTemporaria.Text = "";
            txtVisor.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "1");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "0");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "5");
        }

        private void btncSeis_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            exibeTela(txtTelaTemporaria, "9");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calcula();
            exibeTela(txtVisor, "÷");
            count = 4;
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            calcula();
            exibeTela(txtVisor, "*");
            count = 3;
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            calcula();
            exibeTela(txtVisor, "-");
            count = 2;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calcula();
            exibeTela(txtVisor, "+");
            count = 1;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {

        }

        private void txtResultadoTemporario_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            calcula();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTelaTemporaria.Text = null;
            txtVisor.Text = null;
            operadorTemporario = 0;
            result = 0;
            jaCalculou = false;
            count = 0;
        }

        private void btnEleva_Click(object sender, EventArgs e)
        {
            calcula();
            exibeTela(txtVisor, "²");
            count = 5;
        }
    }
}
