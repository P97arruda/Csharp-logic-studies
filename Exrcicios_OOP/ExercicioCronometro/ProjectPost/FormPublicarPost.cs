namespace ProjectPost
{
    public partial class FormPublicarPost : Form
    {
        Form1 _formPrincipal;

        public FormPublicarPost(Form1 principal)
        {
            InitializeComponent();
            _formPrincipal = principal;
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxTitulo.Text))
            {
                MessageBox.Show("Escreve um título!", "Faltam dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

             // _formPrincipal.Meo = novaBox
            _formPrincipal.post = new Post(textBoxTitulo.Text, textBoxDescricao.Text);
            _formPrincipal.AtualizarPost();

            this.Close();

        }
    }
}
