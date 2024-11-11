using System;

namespace JogoVelha;

public class Jogador
{
    private static int ordem = 1;

    public char Nome { get; }
    public int Numero { get; }

    public Jogador(char nome)
    {
        Nome = nome;
        Numero = ordem;
        ordem++;
    }


}
