using System;

namespace Exercicio01;

public class Orc: IAndar
{
        public void Deslocar(int distancia)
    {
        System.Console.WriteLine("Andando o Orc por " + distancia + " km");
    }
}
