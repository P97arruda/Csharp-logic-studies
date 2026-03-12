namespace ProjectBalao
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciaBalao_Click(object sender, EventArgs e)
        {
            FormEscolherBalao form = new FormEscolherBalao(this);
            form.Show();
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {

        }
    }
}
