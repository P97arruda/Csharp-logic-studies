namespace ProjectBalao
{
    public partial class Form1 : Form
    {
        public Balao Balao { get; set; }

        public Form1()
        {
            InitializeComponent();
            MostrarGroupBox(true);
            btnIniciaBalao.Enabled = false;// no início mostra o groupBox
        }

        private void MostrarGroupBox(bool mostrar)
        {
            groupBox.Visible = mostrar;
            pictureBox1.Visible = !mostrar;
            btnAlterarCor.Enabled = !mostrar;
            btnCima.Enabled = !mostrar;
            btnBaixo.Enabled = !mostrar;
            btnEsquerda.Enabled = !mostrar;
            btnDireita.Enabled = !mostrar;
            lblCorAtual.Visible = !mostrar;
            lblDirecaoAltural.Visible = !mostrar;
            lblAtitudeAtual.Visible = !mostrar;
            btnIniciaBalao.Enabled = !mostrar;
            numericUpDown1.Enabled = !mostrar;
        }

        public void AtualizarBalao()
        {

            if (Balao == null) return;

            switch (Balao.Cor)
            {
                case "Azul":
                    pictureBox1.Image = Properties.Resources.Azul;
                    break;
                case "Amarelo":
                    pictureBox1.Image = Properties.Resources.Amarelo;
                    break;
                case "Verde":
                    pictureBox1.Image = Properties.Resources.Verde;
                    break;
                case "Vermelho":
                    pictureBox1.Image = Properties.Resources.Vermelho;
                    break;
                case "Rainbow":
                    pictureBox1.Image = Properties.Resources.Rainbow;
                    break;
                case "Rosa":
                    pictureBox1.Image = Properties.Resources.Rosa;
                    break;
            }

            lblCorAtual.Text = Balao.Cor;
            lblDirecaoAltural.Text = Balao.Direcao;
            lblAtitudeAtual.Text = Balao.Altura.ToString();

            MoverBalao();
        }

          
        

        private void btnIniciaBalao_Click(object sender, EventArgs e)
        {
            if (Balao == null)
            {
                MessageBox.Show("Primeiro escolhe uma cor!", "Faltam dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AtualizarBalao();
            MostrarGroupBox(false);
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            if (Balao == null) return;
            Balao.Descer((int)numericUpDown1.Value);
            Balao.MudarDirecao("Baixo");
            AtualizarBalao();

        }

        private void lblCorAtual_Click(object sender, EventArgs e)
        {

        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            if (Balao == null) return;
            Balao.MudarDirecao("Esquerda");
            AtualizarBalao();
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            if (Balao == null) return;
            Balao.MudarDirecao("Direita"); 
            AtualizarBalao();
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            Balao.Subir((int)numericUpDown1.Value);
            Balao.MudarDirecao("Cima");
            AtualizarBalao();
        }

        private void btnGrupBoxIniciar_Click(object sender, EventArgs e)
        {
            string corEscolhida = string.Empty;

            if (radioButtonAzul.Checked)
            {
                corEscolhida = "Azul";
            }
            else if (radioButtonAmarelo.Checked)
            {
                corEscolhida = "Amarelo";
            }
            else if (radioButtonVerde.Checked)
            {
                corEscolhida = "Verde";
            }
            else if (radioButtonVermelho.Checked)
            {
                corEscolhida = "Vermelho";
            }
            else if (radioButtonRainbow.Checked)
            {
                corEscolhida = "Rainbow";
            }
            else if (radioButtonRosa.Checked)
            {
                corEscolhida = "Rosa";
            }

            if (string.IsNullOrEmpty(corEscolhida))
            {
                MessageBox.Show("Tens que escolher uma cor!", "Faltam dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Balao = new Balao(corEscolhida);
            groupBox.Visible = false;
            btnIniciaBalao.Enabled = true;
        }

        private void MoverBalao()
        {
            switch (Balao.Direcao)
            {
                case "Cima":
                    pictureBox1.Top -= 10;
                    break;
                case "Baixo":
                    pictureBox1.Top += 10;
                    break;
                case "Esquerda":
                    pictureBox1.Left -= 10;
                    break;
                case "Direita":
                    pictureBox1.Left += 10;
                    break;
            }
        }

        private void btnAlterarCor_Click(object sender, EventArgs e)
        {
            MostrarGroupBox(true); // mostra o groupBox
        }

        private void btnGrupBoxCancelar_Click(object sender, EventArgs e)
        {
            if (Balao != null)
                MostrarGroupBox(false); // esconde se já existe balão
        }
    }
}
