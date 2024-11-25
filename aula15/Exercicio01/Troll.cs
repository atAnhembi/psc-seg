using System;

namespace Exercicio01;

public class Troll : IAndar
{
    public void Deslocar(int distancia)
    {
        System.Console.WriteLine("Andando o Troll por " + distancia + " km");
    }
}
