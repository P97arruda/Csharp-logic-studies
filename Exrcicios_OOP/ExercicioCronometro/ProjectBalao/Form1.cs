namespace ProjectBalao
{
    public partial class Form1 : Form
    {
        public Balao Balao { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void AtualizarBalao()
        {
            if (Balao == null) return;

            // Atualiza a imagem consoante a cor
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

            // Atualiza os labels
            lblCorAtual.Text = Balao.Cor;
            lblDirecaoAltural.Text = Balao.Direcao;
            lblAtitudeAtual.Text = Balao.Altura.ToString();
        }

        private void btnIniciaBalao_Click(object sender, EventArgs e)
        {
            FormEscolherBalao form = new FormEscolherBalao(this);
            form.Show();
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            Balao.Descer(10);
            Balao.MudarDirecao("Baixo");
            AtualizarBalao();

        }

        private void lblCorAtual_Click(object sender, EventArgs e)
        {

        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            Balao.MudarDirecao("Esquerda");
            AtualizarBalao();

        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            Balao.MudarDirecao("Direita");
            AtualizarBalao();

        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            Balao.Subir(10);
            Balao.MudarDirecao("Cima");
            AtualizarBalao();

        }
    }
}
