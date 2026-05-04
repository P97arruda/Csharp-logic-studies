namespace ProjectBalao
{
    public partial class Form1 : Form
    {
        // Balão atualmente controlado pelo formulário
        public Balao Balao { get; set; }

        // Construtor: inicializa o formulário e mostra o painel de seleção de cor
        public Form1()
        {
            InitializeComponent();
            MostrarGroupBox(true);
            btnIniciaBalao.Enabled = false;
        }

        // Mostra ou esconde o painel de configuração e os controlos do balão
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

        // Atualiza a imagem, os labels e move o balão conforme o estado atual
        public void AtualizarBalao()
        {
            // Atualiza a imagem consoante a cor do balão
            if (Balao != null)
            {
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
        }

        // Inicia o balão e esconde o painel de configuração
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

        // Desce o balão o número de metros indicado e atualiza a interface
        private void btnBaixo_Click(object sender, EventArgs e)
        {
            if (Balao == null) return;
            Balao.Descer((int)numericUpDown1.Value);
            Balao.Direcao = "Baixo";
            AtualizarBalao();

        }

        private void lblCorAtual_Click(object sender, EventArgs e)
        {

        }

        // Move o balão para a esquerda e atualiza a interface
        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            if (Balao == null) return;
            Balao.Direcao = "Esquerda";
            AtualizarBalao();
        }

        // Move o balão para a direita e atualiza a interface
        private void btnDireita_Click(object sender, EventArgs e)
        {
            if (Balao == null) return;
            Balao.Direcao = "Direita";
            AtualizarBalao();
        }

        // Sobe o balão o número de metros indicado e atualiza a interface
        private void btnCima_Click(object sender, EventArgs e)
        {
            if (Balao == null) return;
            Balao.Subir((int)numericUpDown1.Value);
            Balao.Direcao = "Cima";
            AtualizarBalao();
        }

        // Lê a cor selecionada, valida a escolha e cria o balão
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

            // Validação: cor obrigatória
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

        // Move a imagem do balão no ecrã consoante a direção atual
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

        // Abre o painel de configuração para alterar a cor do balão
        private void btnAlterarCor_Click(object sender, EventArgs e)
        {
            MostrarGroupBox(true);
        }
        // Fecha o painel de configuração sem alterar o balão atual
        private void btnGrupBoxCancelar_Click(object sender, EventArgs e)
        {
            if (Balao != null)
                MostrarGroupBox(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
