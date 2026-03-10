namespace ProcjetPost
{

    public partial class FormPostPubli : Form
    {
        FormPrinciapll  _formPrincipal;
        Post post3;
        public FormPostPubli(FormPrinciapll princial, Post post)
        {
            InitializeComponent();
            _formPrincipal = princial;
            post3 = post;
            

            //lblTitulo.Text = post3.Titulo;
            //lblDescricao.Text = post3.Descricao;

         
        }

        private void FormPostPubli_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = post3.Titulo;
            lblDescricao.Text = post3.Descricao;
        }



        private void btnLikes_Click(object sender, EventArgs e)
        {
            post3.AddLikes();
            lblLikes.Text = "Like - " + post3.Likes;

        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            post3.AddDislikes();
            lblDislikes.Text = "Dislike - " + post3.DisLikes;

        }
    }
}
