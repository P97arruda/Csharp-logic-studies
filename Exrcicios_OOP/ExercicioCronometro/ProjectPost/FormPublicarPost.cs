namespace ProjectPost
{
    public partial class FormPublicarPost : Form
    {
        // Referência ao formulário principal para atualizar o post após publicação
        Form1 _formPrincipal;

        // Construtor: guarda a referência ao formulário principal
        public FormPublicarPost(Form1 principal)
        {
            InitializeComponent();
            _formPrincipal = principal;
        }

        // Fecha o formulário sem publicar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Valida os dados, cria o post e atualiza o formulário principal
        private void btnPublicar_Click(object sender, EventArgs e)
        {
            // Validação: título obrigatório
            if (string.IsNullOrEmpty(textBoxTitulo.Text))
            {
                MessageBox.Show("Escreve um título!", "Faltam dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria o novo post e atualiza o formulário principal
            _formPrincipal.PostAtual = new Post(textBoxTitulo.Text, textBoxDescricao.Text);
            _formPrincipal.AtualizarPost();

            this.Close();

        }
    }
}
