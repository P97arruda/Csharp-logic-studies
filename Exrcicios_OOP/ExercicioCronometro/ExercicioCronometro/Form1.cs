namespace ExercicioCronometro
{
    public partial class Form1 : Form
    {
        private readonly Cronometro _cronometro;
        public Form1()
        {
            InitializeComponent();

            _cronometro = new Cronometro();
        }

        private void ButtonOnOff_Click(object sender, EventArgs e)
        {
            if (_cronometro.ClockSkate())
            {
                _cronometro.StopClock();
                ButtonOnOff.Text = "Ligar";
                TimerRelogio.Enabled = false;

                //labelContador.Text = _cronometro.GetTimeSpan().ToString();
            }
            else
            {
                _cronometro.StartClock();
                ButtonOnOff.Text = "Desligar";
                TimerRelogio.Enabled = true;
            }

        }

        private void UpdateLabel()
        {
            var tempo = DateTime.Now - _cronometro.StartTime();

            labelContador.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3}", tempo.Hours, tempo.Minutes, tempo.Seconds, tempo.Milliseconds);
        }

        private void TimerRelogio_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }
    }
}
