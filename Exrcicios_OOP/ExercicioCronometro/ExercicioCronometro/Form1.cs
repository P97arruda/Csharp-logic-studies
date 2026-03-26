namespace ExercicioCronometro
{
    public partial class Form1 : Form
    {
        private readonly Cronometro _cronometro;
        public Form1()
        {
            // Construtor: inicializa o formulário e cria o cronómetro
            InitializeComponent();

            _cronometro = new Cronometro();
        }

        // Liga ou desliga o cronómetro e atualiza a interface 
        private void ButtonOnOff_Click(object sender, EventArgs e)
        {
            if (_cronometro.ClockSkate())
            {
                // Parar cronómetro 
                _cronometro.StopClock();
                ButtonOnOff.Text = "Ligar";
                TimerRelogio.Enabled = false;

                //labelContador.Text = _cronometro.GetTimeSpan().ToString();
            }
            else
            {
                // iniciar cronómetro 
                _cronometro.StartClock();
                ButtonOnOff.Text = "Desligar";
                TimerRelogio.Enabled = true;
            }

        }

        // Atualiza o label com o tempo atual no formato HH:MM:SS:ss
        private void UpdateLabel()
        {
            var tempo = DateTime.Now - _cronometro.StartTime();

            labelContador.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3}", tempo.Hours, tempo.Minutes, tempo.Seconds, tempo.Milliseconds);
        }

        // Evento do timer: atualiza o contador a cada tick
        private void TimerRelogio_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }
    }
}
