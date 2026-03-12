namespace ProjectPost
{
    public class Post
    {
        #region Atributos

        private string _titulo;

        private string _descricao;

        private int _likes;

        private int _dislikes;

        private DateTime _data;

        #endregion

        #region Propriedades 

        public string Titulo
        {
            get
            {
                return _titulo;
            }
        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }
        }

        public int Likes
        {
            get
            {
                return _likes;
            }
        }

        public int Dislikes
        {
            get
            {
                return _dislikes;
            }
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }
        }

        #endregion

        #region Metodos

        public Post(string titulo, string descricao)
        {

            _titulo = titulo;
            _descricao = descricao;
            _data = DateTime.Now;
            _likes = 0;
            _dislikes = 0;
        }

        public void Like()
        {
            _likes++;
        }

        public void Dislike()
        {
            _dislikes++;
        }


        #endregion
    }

}
