using System;

namespace ExercicioCarros;

public class Carro
{
    private const double _consumoPadrao = 10;
    public string Marca { get; }
    public string Modelo { get; }
    public double Consumo { get; }
    public double Combustivel
    {
        get
        {
            return _combustivel;
        }
    }
    public double Kilometragem
    {
        get
        {
            return _kilometragem;
        }
    }

    private double _kilometragem;
    private double _combustivel;

    public Carro(string marca, string modelo, double consumo, double combustivel, double kilometragem)
    {
        marca = marca.Trim();
        if (marca.Length > 0)
            Marca = marca;
        else
            Marca = "Indefinido";
        modelo = modelo.Trim();
        if (modelo.Length > 0)
            Modelo = modelo;
        else
            Modelo = "Indefinido";
        if (consumo > 0)
            Consumo = consumo;
        else
            Consumo = _consumoPadrao;
        if (combustivel > 0)
            _combustivel = combustivel;
        if (kilometragem > 0)
            _kilometragem = kilometragem;
    }
    public Carro(string marca, string modelo, double consumo)
    {
        marca = marca.Trim();
        if (marca.Length > 0)
            Marca = marca;
        else
            Marca = "Indefinido";
        modelo = modelo.Trim();
        if (modelo.Length > 0)
            Modelo = modelo;
        else
            Modelo = "Indefinido";
        if (consumo > 0)
            Consumo = consumo;
        else
            Consumo = _consumoPadrao;
    }

    public void Andar(double kilometragem)
    {
        if (kilometragem > 0)
        {
            double combustivelNecessario = kilometragem / Consumo;
            if (Combustivel >= combustivelNecessario)
            {
                _kilometragem += kilometragem;
                _combustivel -= combustivelNecessario;
            }
        }
    }


    public void Abastecer(double combustivel)
    {
        if (combustivel > 0)
        {
            _combustivel += combustivel;
        }
    }
    public string Exibir()
    {
        return "Carro: " + Marca + " : " + Modelo + " : " + Consumo + " ( " + Combustivel + " l) KM " + Kilometragem;
    }
}
