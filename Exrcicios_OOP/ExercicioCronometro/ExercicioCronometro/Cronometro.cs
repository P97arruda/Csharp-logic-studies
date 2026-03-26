namespace ExercicioCronometro
{
    public class Cronometro
    {
        #region Atributos

        private DateTime _start;

        private DateTime _stop;

        private bool _isrunning;


        #endregion

        // Inicia o cronómetro; lança execeção se ja estiver a correr 
        public void StartClock()
        {
            if (_isrunning)
            
                  throw new InvalidOperationException("O cronómetro já está ligado!");
                _start = DateTime.Now;
                _isrunning = true;
        }

        // Para o cronómetro; lança execeção se já estiver parado
        public void StopClock()
        {
            if (!_isrunning)
                throw new InvalidOperationException("O cronómetro já está desligado!");
                _stop = DateTime.Now;
                _isrunning = false;
        }

        // Devolve o tempo total entre o inicio e o fim 
        public TimeSpan GetTimeSpan() 
        { 
            return _stop - _start;
        }

        // Indica se o cronómentro está a correr 
        public bool ClockSkate()
        {
            return _isrunning;
        }

        // Devolve o momento em que o cronómentro foi iniciado 
        public DateTime StartTime()
        {
            return _start;
        }
    }
}
