using Televisao.Console;

namespace Televisao.Forms
{

    public partial class frmPrincial : Form
    {
        // Objeto responsável por controlar a Box
        public Box Meo { get; set; }

        /// <summary>
        /// Inicializa o formulário e cria a Box 
        /// </summary>
        public frmPrincial()
        {
            InitializeComponent();

            // Cria a Box
            Meo = new Box();

            // Ativa botão e mostra mensagem inicial 
            if (Meo != null)
            {
                btnOnOff.Enabled = true;
                lblInfo.Text = Meo.Mensagem;
            }

        }
        
        private void frmPrincial_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Liga ou desliga a Box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            // Se está ligado -> desliga 
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
                // Se está desligado -> liga 
                Meo.Ligar();
                lblInfo.Text = Meo.Mensagem;
                btnOnOff.Text = "Desligar";
                
                // Atualiza interface (ligado)
                groupBoxCanais.Enabled = true;
                lblCanal.Text = Meo.Canal.ToString();

                //Volume
                groupBoxVolume.Enabled = true;
                progressBarVolume.Value = Meo.Volume;

                //Atualizar Total de canais 
                AtualizarTotalCanais(Meo.NumeroCanais);

            }
        }

        /// <summary>
        /// Avança um canal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAumentaCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal++;
            lblCanal.Text = Meo.Canal.ToString();
        }

        /// <summary>
        /// Recua um canal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDiminuiCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal--;
            lblCanal.Text = Meo.Canal.ToString();
        }
        /// <summary>
        /// Diminui o volume 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndiminuiVolume_Click(object sender, EventArgs e)
        {
            Meo.Volume--;
            progressBarVolume.Value = Meo.Volume;

        }

        /// <summary>
        /// Aumenta o volume 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAumenteVolume_Click(object sender, EventArgs e)
        {
            Meo.Volume++;
            progressBarVolume.Value = Meo.Volume;

        }
        /// <summary>
        /// Abre o formulário para criar um nova Box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNovaBox frmNova = new frmNovaBox(this);
            frmNova.Show();
        }
       
        private void lblTotalCanais_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Atualiza o label com total de canais disponivel 
        /// </summary>
        /// <param name="total"></param>
        public void AtualizarTotalCanais(int total)
        {
            lblTotalCanais.Text = "Total de canais: " + total;
        }
        /// <summary>
        /// Ativa ou desativa o mute; bloqueia os botões de volume quando ativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMute_Click(object sender, EventArgs e)
        {
            Meo.AtivarMute();

            btnAumenteVolume.Enabled = !Meo.Mute;
            btndiminuiVolume.Enabled = !Meo.Mute;

            progressBarVolume.Value = Meo.Volume;

            lblInfo.Text = Meo.Mute ? "Mute ativado" : "Som ligado";
        }

        private void btnCanalAnterior_Click(object sender, EventArgs e)
        {
            Meo.VoltarCanalAnterior();
            lblCanal.Text = Meo.Canal.ToString();
        }
    }

}
