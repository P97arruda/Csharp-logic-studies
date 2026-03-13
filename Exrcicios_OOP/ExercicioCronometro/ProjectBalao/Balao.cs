namespace ProjectBalao
{
    public class Balao
    {

        #region Atributos

        private string _cor;

        private string _direcao;

        private int _altura;

        #endregion

        #region Propriedades

        public string Cor
        {
            get
            {
                return _cor;
            }
        }

        public string Direcao
        {
            get
            {
                return _direcao;
            }
        }

        public int Altura
        {
            get
            {
                return _altura;
            }
        }
        #endregion


        #region Metodos 

        public Balao(string cor)
        {
            _cor = cor;
            _direcao = "Parado";
            _altura = 0;
        }

        public void MudarCor(string cor)
        {
            _cor = cor;
        }

        public void MudarDirecao(string direcao)
        {
            _direcao = direcao;
        }

        public void Subir(int metros)
        {
            _altura += metros;
        }

        public void Descer(int metros)
        {
            if (_altura - metros < 0)
            {
                _altura = 0;
            }
            else
            {
                _altura -= metros;
            }
        }

        #endregion
    }

}

       
  
