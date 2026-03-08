using Televisao.Console;

namespace Televisao.Forms
{
    public partial class frmPrincial : Form
    {
        public Box Meo { get; set; }

        //Box _meo;
        //public Box Meo
        //{
        //    get
        //    {
        //        return _meo;
        //    }
        //    set
        //    {
        //        _meo = value;
        //    }
        //}

        public frmPrincial()
        {
            InitializeComponent();
            Meo = new Box();

            if (Meo != null)
            {
                btnOnOff.Enabled = true;
                lblInfo.Text = Meo.Mensagem;
            }

        }

        private void frmPrincial_Load(object sender, EventArgs e)
        {

        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (Meo.Estado)
            {
                Meo.Desligar();
                lblInfo.Text = Meo.Mensagem;
                btnOnOff.Text = "Ligar";

                //Canais
                groupBoxCanais.Enabled = false;
                lblCanal.Text = "-";

                //Volume
                groupBoxVolume.Enabled = false;
                progressBarVolume.Value = 0;

                //Atualizar total de canais 
                lblTotalCanais.Text = "Total de canais: -"; 

            }
            else
            {
                Meo.Ligar();
                lblInfo.Text = Meo.Mensagem;
                btnOnOff.Text = "Desligar";
                //Canais 
                groupBoxCanais.Enabled = true;
                lblCanal.Text = Meo.Canal.ToString();

                //Volume
                groupBoxVolume.Enabled = true;
                progressBarVolume.Value = Meo.Volume;

                //Atualizar Total de canais 
                AtualizarTotalCanais(Meo.NumeroCanais); 

            }
        }

        private void btnAumentaCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal++;
            lblCanal.Text = Meo.Canal.ToString();
        }

        private void btnDiminuiCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal--;
            lblCanal.Text = Meo.Canal.ToString();
        }

        private void btndiminuiVolume_Click(object sender, EventArgs e)
        {
            Meo.Volume--;
            progressBarVolume.Value = Meo.Volume;

        }

        private void btnAumenteVolume_Click(object sender, EventArgs e)
        {
            Meo.Volume++;
            progressBarVolume.Value = Meo.Volume;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNovaBox frmNova = new frmNovaBox(this);
            frmNova.Show();
        }

        private void lblTotalCanais_Click(object sender, EventArgs e)
        {

        }

        public void AtualizarTotalCanais(int total)
        {
            lblTotalCanais.Text = "Total de canais: " + total;
        }



        private void btnMute_Click(object sender, EventArgs e)
        {
            Meo.AtivarMute();

            if (Meo.Mute)
            {
                // desliga botões de volume
                btnAumenteVolume.Enabled = false;
                btndiminuiVolume.Enabled = false;

                // desliga barra de volume
                progressBarVolume.Value = 0;

                lblInfo.Text = "Mute ativado";
            }
            else
            {
                // ativa botões novamente
                btnAumenteVolume.Enabled = true;
                btndiminuiVolume.Enabled = true;

                // volta volume anterior
                progressBarVolume.Value = Meo.Volume;

                lblInfo.Text = "Som ligado";
            }
        }
    }
}
