namespace ProjectBalao
{
    public partial class FormEscolherBalao : Form
    {


        Form1 _formPrinciapal;
        public FormEscolherBalao()
        {
            InitializeComponent();
        }
        public FormEscolherBalao(Form1 princiapl)
        {
            InitializeComponent();
            _formPrinciapal = princiapl;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string corEscolhida = "";

            if (radioButtonAzul.Checked) corEscolhida = "Azul";
            else if (radioButtonAmarelo.Checked) corEscolhida = "Amarelo";
            else if (radioButtonVerde.Checked) corEscolhida = "Verde";
            else if (radioButtonVermelho.Checked) corEscolhida = "Vermelho";
            else if (radioButtonRainbow.Checked) corEscolhida = "Rainbow";
            else if (radioButtonRosa.Checked) corEscolhida = "Rosa";

            if (string.IsNullOrEmpty(corEscolhida))
            {
                MessageBox.Show("Tens que escolher uma cor!", "Faltam dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_formPrinciapal == null)
            {
                Form1 form = new Form1();
                form.Balao = new Balao(corEscolhida);
                form.AtualizarBalao();
                form.Show();
                this.Close();
            }
            else
            {
                _formPrinciapal.Balao.MudarCor(corEscolhida);
                _formPrinciapal.AtualizarBalao();
                this.Close();
            }
        }

        private void radioButtonAzul_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAmarelo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonVerde_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonVermelho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRainbow_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
