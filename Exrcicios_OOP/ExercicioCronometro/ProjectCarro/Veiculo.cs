using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarro
{
    public class Veiculo
    {
        #region Atributos

        private string _matricula;
        private double _quilometragem;
        private double _capacidade;
        private double _litrosAtuais;
        private double _consumoMedio;
        private int _viagens;

        #endregion

        #region Propriedades

        public string Matricula
        {
            get
            {
                return _matricula;
            }
        }

        public double Quilometragem
        {
            get
            {
                return _quilometragem;
            }
        }

        public double Capacidade
        {
            get
            {
                return _capacidade;
            }
        }

        public double LitrosAtuais
        {
            get
            {
                return _litrosAtuais;
            }
        }

        public double ConsumoMedio
        {
            get
            {
                return _consumoMedio;
            }
        }

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

        // Calcula quantos km pode percorrer com o combustível atual
        public double KmDisponiveis()
        {
            return (_litrosAtuais / _consumoMedio) * 100;
        }

        //Verifica se esta na reserva (menos de 10 litros)
        public bool EstaNaReserva()
        {
            return _litrosAtuais <= 10;
        }

        // Registra um viagem 
        public bool Viajar(double km)
        {

            double litrosNecessarios = (km * _consumoMedio) / 100;

            if(litrosNecessarios > _litrosAtuais)
            {
                return false;
            }

            _litrosAtuais -= litrosNecessarios;
            _quilometragem += km;
            _viagens++;
            
            return true;
        }

        public double Abastecer(double litros)
        {
            double espacoDisponivel = _capacidade - _litrosAtuais;

            if(litros > espacoDisponivel)
                litros = espacoDisponivel;

            _litrosAtuais += litros;
            return litros;
        }




        #endregion

    }
}
