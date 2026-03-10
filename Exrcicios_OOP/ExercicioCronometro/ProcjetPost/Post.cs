namespace ProcjetPost
{
    public class Post
    {
        #region Atributos

        private string _titulo;
        private string _descricao;
        private int _likes;
        private int _disLikes;
        private DateTime _dataCriacao;

        #endregion

        #region Propriedades

        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                _titulo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                _descricao = value;
            }
        }

        public int Likes
        {
            get
            {
                return _likes;
            }
            set
            {
                _likes = value;
            }
        }
        public int DisLikes
        {
            get
            {
                return _disLikes;
            }
            set
            {
                _disLikes = value;
            }
        }
        public DateTime DataCriacao
        {
            get
            {
                return _dataCriacao;
            }
            set
            {
                _dataCriacao = value;
            }
        }



        #endregion

        #region Metodos

        public Post()
        {
            _likes = 0;
            _disLikes = 0;
            _dataCriacao = DateTime.Now;
        }

        public void DefinirTitulo(string titulo)
        {
            this.Titulo = titulo;
        }

        public void DefinirDescricao(string descricao)
        {
            this.Descricao = descricao;
        }

        public void AddLikes()
        {
            Likes++;

        }

        public void AddDislikes()
        {
            DisLikes++;

        }


        #endregion


    }
}
