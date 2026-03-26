using System.Numerics;

namespace Televisao.Console
{
    public class Box
    {

        #region Atributos 
        
        // Guarda o canal atual
        private int _canal;

        // Guarda o volume atual
        private int _volume;

        // Guarda mensagens do sistema (estado da box)
        private string _mensagem;

        //Número máximo de canais disponiveis 
        private int _numeroCanais;

        // Indica se a box está ligado ou desligado
        private bool _estado;

        // Indica se o som está em mute
        private bool _mute;

        // Guarda o canal anterior (para voltar atrás)
        private int _canalAnterior;


        #endregion

        #region Propriedades

        /// <summary>
        /// Propriedade para controlar o canal 
        /// </summary>
        public int Canal
        {
            get
            {
                return _canal; // devolve o canal atual 
            }

            set
            {
                // só permite canais válidos 
                if (value >= 0 && value <= _numeroCanais)
                {
                    _canalAnterior = _canal;  // guarda o canal atual
                    _canal = value; // muda para o novo canal 
                }
            }

        }

        /// <summary>
        /// Números total de canais 
        /// </summary>
        public int NumeroCanais
        {
            get
            {
                return _numeroCanais;
            }
            set
            {
                _numeroCanais = value;
            }
        }

        /// <summary>
        /// Indica se está em mute 
        /// </summary>
        public bool Mute
        {
            get
            {
                return _mute;
            }

        }
        /// <summary>
        /// Controla o volume 
        /// </summary>
        public int Volume
           {

            get
            {
                // se estiver em mute, volume é 0
                if (_mute)
                    return 0;

                return _volume;
            }

            set
            {
                // só aceita valores entre 0 e 100
                if (value >= 0 && value <= 100)
                {
                    _volume = value;
                }
            }
        }
        
        /// <summary>
        /// Propriedade só leitura (não pode alterar de fora)
        /// </summary>
        public string Mensagem
        {
            get
            {
                return _mensagem;
            }
            /*  set
              {
                  _mensagem = value;
              }*/
        }
        /// <summary>
        /// Mostra se a box está ligada ou desligada 
        /// </summary>
        public bool Estado
        {
            get
            {
                return _estado;
            }
        }
        #endregion


        #region Métodos

        /// <summary>
        /// Construtor - define valores iniciais 
        /// </summary>
        public Box()
        {
            _estado = false; //começa desligada
            _canal = 1; // canal inicial 
            _volume = 50; // volume padrão
            _mensagem = "Box criada com sucesso!!";
            _numeroCanais = 10; //total de canais 
        }
        /// <summary>
        /// Liga a box 
        /// </summary>
        public void Ligar()
        {
            _estado = true;
            try
            {
                LerInfo();
            }
            catch (Exception e)
            {

                _mensagem = e.Message;
            }


            _mensagem = "Box ligada com sucesso!!";
        }

        /// <summary>
        /// Desliga a box 
        /// </summary>
        public void Desligar()
        {
            _estado = false;

            try
            {
                // guarda os dados no ficheiro
                GravarInfo();
            }
            catch (Exception e)
            {
                _mensagem = e.Message;
            }

            _mensagem = "Box desligada!!!";
        }

        /// <summary>
        /// Guarda canal e volume num ficheiro
        /// </summary>
        private void GravarInfo()
        {
            string ficheiro = @"tvInfo.txt";

            // formato: canal;volume
            string linha = $"{_canal};{_volume}";

            StreamWriter sw = new StreamWriter(ficheiro, false);

            // se o ficheiro não existir, cria 
            if (!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }

            // escreve no ficheiro
            sw.WriteLine(linha);
            sw.Close();
        }
        /// <summary>
        /// Lê canal e volume do ficeiro
        /// </summary>
        private void LerInfo()
        {
            string ficheiro = @"tvInfo.txt";

            StreamReader sr;

            //8;40

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = new string[2];

                    campos = linha.Split(';');

                    Canal = Convert.ToInt32(campos[0]);
                    Volume = Convert.ToInt32(campos[1]);
                }// fim do while

                sr.Close();
            }
        }
        /// <summary>
        /// Ativa ou desativa o mute 
        /// </summary>
        public void AtivarMute()
        {
            _mute = !_mute;
        }
        // Volta para o canal anterior 
        public void VoltarCanalAnterior()
        {
            int temp = _canal;
            _canal = _canalAnterior;
            _canalAnterior = temp;
        }


        #endregion

    }
}
