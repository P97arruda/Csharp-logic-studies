using System.Windows.Forms;

namespace ProcjetPost
{
    public partial class FormPrinciapll : Form
    {

        public Post PostAtual { get; set; }

        public void AdicionarPost(Post post)
        {
            PostAtual = post;

            
          
        }


        public FormPrinciapll()
        {
            InitializeComponent();
        }

        private void BtnCriaPost_Click(object sender, EventArgs e)
        {
            

            FormCriaPost formCriaPost = new FormCriaPost(this);
            formCriaPost.ShowDialog();

        }
    }
}
