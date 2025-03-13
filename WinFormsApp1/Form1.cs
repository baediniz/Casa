namespace WinFormsApp1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private Operacao OperacaoSelec { get; set; }
        private enum Operacao
        {
            Soma,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelec = Operacao.Soma;
            txtResultado.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelec = Operacao.Subtracao;
            txtResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelec = Operacao.Multiplicacao;
            txtResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelec = Operacao.Divisao;
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelec)
            {
                case Operacao.Soma:
                   
                    break;
                case Operacao.Subtracao:
                    
                    break;
                case Operacao.Multiplicacao:
                    
                    break;
                case Operacao.Divisao:
                    
                    break;
            }
        }
    }
}
