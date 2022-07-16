namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        float num = 0;
        int count;

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
            txtVisor.Text = txtVisor.Text + "1";
            num = 1;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
           txtVisor.Text = txtVisor.Text + "0";
            num = 0;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
             txtVisor.Text = txtVisor.Text + "2";
            num = 2;
        }

        private void btnTres_Click(object sender, EventArgs e)
        { 
            txtVisor.Text = txtVisor.Text + "3";
            num = 3;
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
             txtVisor.Text = txtVisor.Text + "4";
            num = 4;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "5";
            num = 5;
        }

        private void btncSeis_Click(object sender, EventArgs e)
        {
             txtVisor.Text = txtVisor.Text + "6";
            num = 6;
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "7";
            num = 7;
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
             txtVisor.Text = txtVisor.Text + "8";
            num = 8;  
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "9";
            num = 9;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "÷";
            count = 4;
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "*";
            count = 3;
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
             txtVisor.Text = txtVisor.Text + "-";
            count = 2;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
             txtVisor.Text = txtVisor.Text + "+";
            count = 1;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            try
            {
                string visorTemporario = txtVisor.Text;
                visorTemporario = visorTemporario.Remove(visorTemporario.Length - 1);
                txtVisor.Text = visorTemporario;
            }
            catch { };
        }

        private void txtResultadoTemporario_TextChanged(object sender, EventArgs e)
        {
            
        }
        float calculo;
        private void btnIgual_Click(object sender, EventArgs e)
        {
            
            switch (count)
            {
                case 1:
                    { 
                    calculo = num + float.Parse(txtResultadoTemporario.Text);
                    txtResultadoTemporario.Text = calculo.ToString();
                    break;
                    }
                case 2:
                    {
                        calculo = num - float.Parse(txtResultadoTemporario.Text);
                        txtResultadoTemporario.Text = calculo.ToString();
                        break;
                    }
                case 3:
                    
                        calculo = num * float.Parse(txtResultadoTemporario.Text);
                        txtResultadoTemporario.Text = Convert.ToString(calculo);
                        break;
                       
                  
                case 4:

                default:
                    { 
                        break;
                    }


            }
        }
    }
}