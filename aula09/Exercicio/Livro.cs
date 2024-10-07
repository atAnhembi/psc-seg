using System;

namespace Exercicio;

public class Livro
{

    public string Titulo { get; }
    public string Autor { get; }
    public int NumeroPaginas { get; }

    // atributo
    private double _preco = 10; 

    //Propriedade
    public double Preco
    {
        get
        {
            return _preco;

        }
        set
        {
            if (value > 0) // regra que só aceita valor > 0
            {
                _preco = value;
            }
        }
    }

    public Livro(string titulo, string autor, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

}
