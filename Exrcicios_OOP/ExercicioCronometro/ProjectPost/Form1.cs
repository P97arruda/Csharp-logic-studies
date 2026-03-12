namespace ProjectPost
{
    public partial class Form1 : Form
    {
        public Post post {  get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        public void AtualizarPost()
        {
            lblTitulo.Text = post.Titulo;
            lblDescricao.Text = post.Descricao;

            lblData.Text = "Criado em: " + post.Data.ToString();
            lblLike.Text = "Likes - " + post.Likes;
            lblDisLike.Text = "Dislikes - " + post.Dislikes;

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
            post.Like();
            AtualizarPost();

        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            post.Dislike();
            AtualizarPost();
        }
    }
}
