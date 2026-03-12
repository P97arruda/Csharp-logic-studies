namespace ProjectPost
{
    public partial class Form1 : Form
    {
        public Post PostAtual {  get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        public void AtualizarPost()
        {
            lblTitulo.Text = PostAtual.Titulo;
            lblDescricao.Text = PostAtual.Descricao;

            lblData.Text = "Criado em: " + PostAtual.Data.ToString();
            lblLike.Text = "Likes - " + PostAtual.Likes;
            lblDisLike.Text = "Dislikes - " + PostAtual.Dislikes;

            btnCriaPost.Enabled = false;
            lblTitulo.Visible = true;
            lblDescricao.Visible = true;
            lblData.Visible = true;
            lblLike.Visible = true;
            lblDisLike.Visible = true;
            btnLike.Visible = true;
            btnDislike.Visible = true;
        }

        private void btnCriaPost_Click(object sender, EventArgs e)
        {
            FormPublicarPost form = new FormPublicarPost(this);
            form.Show();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            PostAtual.Like();
            AtualizarPost();

        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            PostAtual.Dislike();
            AtualizarPost();
        }
    }
}
