namespace ProcjetPost
{
    public partial class FormCriaPost : Form
    {
        FormPrinciapll _formPrinciapll;
        Post post = new Post();
        public FormCriaPost(FormPrinciapll princiapl)
        {
            InitializeComponent();
            _formPrinciapll = princiapl;

        }

        private void FormCriaPost_Load(object sender, EventArgs e)
        {
            

        }

        private void textBoxTituloPost_TextChanged(object sender, EventArgs e)
        {

        }
        


        private void btnPublicarPost_Click(object sender, EventArgs e)
        {
            post.DefinirTitulo(textBoxTituloPost.Text);
            post.DefinirDescricao(textBoxDescricao.Text);

            

            this.Close();
        }

        private void btnCancelarPost_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
