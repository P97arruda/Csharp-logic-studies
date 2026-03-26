namespace ProjectBalao
{
    public class Balao
    {

        #region Atributos

        private string _cor; // Cor do balão

        private string _direcao; // Direção atual do balão

        private int _altura; // ALtura atual em metros 

        #endregion

        #region Propriedades

        // Cor do balão 
        public string Cor
        {
            get
            {
                return _cor;
            }
            set
            {
                _cor = value;
            }
        }

        // Direção atual do balão 
        public string Direcao
        {
            get
            {
                return _direcao;
            }
            set
            {
                _direcao = value;
            }
        }

        // Altura atual do balão em metros 
        public int Altura
        {
            get
            {
                return _altura;
            }
        }
        #endregion


        #region Metodos 

        // Construtor: cria o balão com a cor indicada, para e ao nivel do chão
        public Balao(string cor)
        {
            _cor = cor;
            _direcao = "Parado";
            _altura = 0;
        }
        // Sobe o balão o número de metros indicado
        public void Subir(int metros)
        {
            _altura += metros;
        }

        // Desce o balão o número de metros indicado: não permite altura negativa
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

       
  
