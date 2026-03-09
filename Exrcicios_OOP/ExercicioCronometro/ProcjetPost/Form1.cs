namespace ProcjetPost
{
    public partial class FormPrinciapll : Form
    {
        public FormPrinciapll()
        {
            InitializeComponent();
        }

        private void BtnCriaPost_Click(object sender, EventArgs e)
        {
            FormCriaPost formCriaPost = new FormCriaPost();
            formCriaPost.Show();

        }
    }
}
