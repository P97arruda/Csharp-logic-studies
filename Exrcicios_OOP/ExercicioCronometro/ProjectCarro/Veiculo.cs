namespace ProjectCarro
{
    public class Veiculo
    {
        #region Atributos


        private string _matricula; // Matricula de veiculo 

        private double _quilometragem; //total de km já pecorridos 

        private double _capacidade; // Capacidade máxima do tanque (litros)

        private double _litrosAtuais; // Quantidade atual de combustível no tanque

        private double _consumoMedio; // Consumo médio (litros por 100 km)

        private int _viagens; // Quantidade de viagens realizadas

        #endregion

        #region Propriedades

        /// Retorna a matrícula do veículo
        public string Matricula
        {
            get
            {
                return _matricula;
            }
        }

        /// Retorna a quilometragem total
        public double Quilometragem
        {
            get
            {
                return _quilometragem;
            }
        }

        /// Retorna a capacidade do tanque
        public double Capacidade
        {
            get
            {
                return _capacidade;
            }
        }

        /// Retorna os litros atuais no tanque
        public double LitrosAtuais
        {
            get
            {
                return _litrosAtuais;
            }
        }

        /// Retorna o consumo médio do veículo
        public double ConsumoMedio
        {
            get
            {
                return _consumoMedio;
            }
        }

        /// Retorna o número de viagens realizadas
        public int Viagens
        {
            get
            {
                return _viagens;
            }
        }

        #endregion

        #region Metodos

        public Veiculo(string matricula, double capacidade, double consumoMedio)
        {
            _matricula = matricula;
            _capacidade = capacidade;
            _consumoMedio = consumoMedio;
            _quilometragem = 0;
            _litrosAtuais = 0;
            _viagens = 0;
        }

        /// Calcula quantos km ainda pode andar com o combustível atual
        public double KmDisponiveis()
        {
            return (_litrosAtuais / _consumoMedio) * 100;
        }

        /// Verifica se o veículo está na reserva (<= 10 litros)
        public bool EstaNaReserva()
        {
            return _litrosAtuais <= 10;
        }

        /// Realiza uma viagem se houver combustível suficiente
        public bool Viajar(double km)
        {
            // Calcula litros necessários para a viagem
            double litrosNecessarios = (km * _consumoMedio) / 100;

            // Verifica se tem combustível suficiente
            if (litrosNecessarios > _litrosAtuais)
            {
                return false;
            }

            // Atualiza os dados do veículo
            _litrosAtuais -= litrosNecessarios;
            _quilometragem += km;
            _viagens++;

            return true;
        }

        /// Abastece o veículo sem ultrapassar a capacidade do tanque
        public double Abastecer(double litros)
        {
            // Calcula espaço disponível no tanque
            double espacoDisponivel = _capacidade - _litrosAtuais;

            // Se passar do limite, ajusta
            if (litros > espacoDisponivel)
                litros = espacoDisponivel;

            _litrosAtuais += litros;
            return litros;
        }
        
        #endregion
    }
}
