using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1;

public class Carro
{
    #region Atributos

    string _marca;

    string _modelo;

    string _cor;

    int _velocidade;

    int _velocidadeMaxima;

    bool _ligado;

    string _estado;

    #endregion

    #region Propriedades

    public string Estado
    {
        get {  return _estado; }
    }

    public bool Ligado
    {
        get { return _ligado; }
    }

    public int Velocidade
    {
        get { return _velocidade; }

        set 
        {
            if (value >= 0 && value <= _velocidadeMaxima)
            {
                _velocidade = value;
            }
           
        }
    }

    public int VelocidadeMaxima
    {
        get { return _velocidadeMaxima; }

        set { _velocidadeMaxima = value; }
    }


    #endregion




    #region Métodos

    // Método especial chamado de costrutor
    //Construtor por default
    public Carro()
    {
        _marca = "Renault";
        _modelo = "Captur";
        _cor = "Vermelho";
        _velocidade = 0;
        _velocidadeMaxima = 20;
        _ligado = false;
        _estado = $"Foi ciado um {_marca} {_modelo}, {_cor} com sucesso!";
    }

    //Construtor 
    public Carro(string marca, string modelo, string cor)
    {
        _marca = marca;
        _modelo = modelo;
        _cor = cor;
        _velocidade = 0;
        _velocidadeMaxima = 20;
        _ligado = false;
        _estado = $"Foi ciado um {_marca} {_modelo}, {_cor} com sucesso!";
    }

    public void Ligar()
    {
        _ligado = true;
        _estado = "Bruummm Bruummm"; 
    }

    public void Desligar()
    {
        _ligado = false;
        _estado = "Puf";
    }


    #endregion
}
