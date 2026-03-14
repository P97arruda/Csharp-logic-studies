namespace ProjectCarro
{
    public partial class Form1 : Form
    {
        public Veiculo Veiculo { get; set; }
        public Form1()
        {
            InitializeComponent();

            MostrarGroupBox(true);
        }

        private void MostrarGroupBox(bool mostrar)
        {
            groupBoxDadosVeiculo.Visible = mostrar;
            groupBoxMeuCarro.Visible = !mostrar;
            btnViajar.Enabled = !mostrar;
            btnAbastecer.Enabled = !mostrar;
            btnMostrarDetalhe.Enabled = !mostrar;
            numericUpKM.Enabled = !mostrar;
            numericUpLitros.Enabled = !mostrar;
        }

        private void AtualizarVeiculo()
        {
            if (Veiculo == null) return;

            lblMatricula.Text = Veiculo.Matricula;
            lblDeposito.Text = Veiculo.LitrosAtuais.ToString("F2") + " / " + Veiculo.Capacidade.ToString("F2");
            lblViagens.Text = Veiculo.Viagens.ToString();
            lblKMdisponiveis.Text = Veiculo.KmDisponiveis().ToString("F2");
            lblQuilomentragem.Text = Veiculo.Quilometragem.ToString("F2");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Valida a matrícula
            if (string.IsNullOrEmpty(textBoxM1.Text) ||
                string.IsNullOrEmpty(textBoxM2.Text) ||
                string.IsNullOrEmpty(textBoxM3.Text))
            {
                MessageBox.Show("Preenche a matrícula!", "Faltam dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Junta a matrícula
            string matricula = textBoxM1.Text + "-" + textBoxM2.Text + "-" + textBoxM3.Text;

            // Cria o veículo
            Veiculo = new Veiculo(matricula, (double)numeUpDown1Capacidade.Value, (double)numeDownConsumo.Value);

            AtualizarVeiculo();
            MostrarGroupBox(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textBoxM1.Clear();
            textBoxM2.Clear();
            textBoxM3.Clear();
        }

        private void btnViajar_Click(object sender, EventArgs e)
        {
            if (Veiculo == null) return;

            double km = (double)numericUpKM.Value;
            bool sucesso = Veiculo.Viajar(km);

            if (sucesso)
            {
                MessageBox.Show("Viagem de " + km + " km registada com sucesso!",
                    "Viajar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tem que abastecer o carro!",
                    "Sem combustível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            AtualizarVeiculo();

        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            if (Veiculo == null) return;

            double litros = (double)numericUpLitros.Value;
            double litrosAbastecidos = Veiculo.Abastecer(litros);

            MessageBox.Show("Abasteceu " + litrosAbastecidos.ToString("F2") + " litros com sucesso!",
                "Abastecer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizarVeiculo();

        }

        private void btnMostrarDetalhe_Click(object sender, EventArgs e)
        {
            if (Veiculo == null) return;

            MessageBox.Show(
                "Matrícula: " + Veiculo.Matricula + "\n" +
                "Km Disponíveis: " + Veiculo.KmDisponiveis().ToString("F2") + "\n" +
                "Depósito: " + Veiculo.LitrosAtuais.ToString("F2") + " / " + Veiculo.Capacidade + "\n" +
                "Viagens: " + Veiculo.Viagens + "\n" +
                "Quilometragem: " + Veiculo.Quilometragem.ToString("F2") + " km\n" +
                "Na reserva: " + (Veiculo.EstaNaReserva() ? "Sim" : "Não"),
                "Detalhes do Veículo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCriarNovoCarro_Click(object sender, EventArgs e)
        {
            Veiculo = null;
            textBoxM1.Clear();
            textBoxM2.Clear();
            textBoxM3.Clear();
            MostrarGroupBox(true);
        }
    }
}
