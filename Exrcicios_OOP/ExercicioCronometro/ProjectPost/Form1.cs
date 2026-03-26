namespace ProjectPost
{
    public partial class Form1 : Form
    {
        // Post atualmente exibido no formulario 
        public Post PostAtual {  get; set; }

        // Construtor: inicializa o formulário
        public Form1()
        {
            InitializeComponent();
        }

        // Atualiza todos os labels com os dados do post e torna os controlos visíveis
        public void AtualizarPost()
        {
            lblTitulo.Text = PostAtual.Titulo;
            lblDescricao.Text = PostAtual.Descricao;

            lblData.Text = "Criado em: " + PostAtual.Data.ToString();
            lblLike.Text = "Likes - " + PostAtual.Likes;
            lblDisLike.Text = "Dislikes - " + PostAtual.Dislikes;

            // Desativa o botão de criar post pois já existe um post ativo
            btnCriaPost.Enabled = false;
            
            // Torna visiveis os elementos do post
            lblTitulo.Visible = true;
            lblDescricao.Visible = true;
            lblData.Visible = true;
            lblLike.Visible = true;
            lblDisLike.Visible = true;
            btnLike.Visible = true;
            btnDislike.Visible = true;
        }

        // Abre o formulário para criar um novo post 
        private void btnCriaPost_Click(object sender, EventArgs e)
        {
            FormPublicarPost form = new FormPublicarPost(this);
            form.Show();
        }

        // Regista um like no post e atualiza a interface
        private void btnLike_Click(object sender, EventArgs e)
        {
            PostAtual.Like();
            AtualizarPost();

        }

        // Regista um dislike no post e atualiza a interface
        private void btnDislike_Click(object sender, EventArgs e)
        {
            PostAtual.Dislike();
            AtualizarPost();
        }
    }
}
