namespace ProjectPost
{
    public class Post
    {
        #region Atributos

        private string _titulo;  // Titulo do post
        
        private string _descricao; // Discrição do post

        private int _likes; // Contador de likes 

        private int _dislikes; // Contador de dislikes 

        private DateTime _data; // Data de criação do post

        #endregion

        #region Propriedades 

        // Devolve o titulo do post (só leitura)
        public string Titulo
        {
            get
            {
                return _titulo;
            }
        }
        
        // Devolve a descrição do post (só leitura)
        public string Descricao
        {
            get
            {
                return _descricao;
            }
        }

        // Devolve o número de likes (só leitura)
        public int Likes
        {
            get
            {
                return _likes;
            }
        }

        // Devolve o numero de dislikes (só leitura)
        public int Dislikes
        {
            get
            {
                return _dislikes;
            }
        }

        // Devolve a data em que o post foi criado (só leitura)
        public DateTime Data
        {
            get
            {
                return _data;
            }
        }

        #endregion

        #region Metodos

        // Construtor: recebe o titulo e descrição, define a data para agora e inicializa os contadores a zero
        public Post(string titulo, string descricao)
        {

            _titulo = titulo;
            _descricao = descricao;
            _data = DateTime.Now;
            _likes = 0;
            _dislikes = 0;
        }

        // Adiciona um like ao post
        public void Like()
        {
            _likes++;
        }

        // Adiciona um dislike ao post
        public void Dislike()
        {
            _dislikes++;
        }
        
        #endregion
    }

}
