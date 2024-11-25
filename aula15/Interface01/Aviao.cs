using System;

namespace Interface01;

public class Aviao : IMotor
{
    public void Desligar()
    {
        System.Console.WriteLine("Desligando o motor do avião...");
    }

    public void Ligar()
    {
        System.Console.WriteLine("Ligando o motor do avião...");
    }
}
