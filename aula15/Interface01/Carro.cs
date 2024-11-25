using System;

namespace Interface01;

public class Carro : IMotor
{
    public void Desligar()
    {
        System.Console.WriteLine("Desligando o motor do carro...");
    }

    public void Ligar()
    {
        System.Console.WriteLine("Ligando o motor do carro...");
    }
}
