using System;

namespace Exemplo03;

public class Conta
{
    public string Numero { get; }

    // Estamos usando uma PROPRIEDADE
    public double Saldo { get; set; }

    // Construtor tem um mesmo nome da classe
    public Conta(string numero)
    {
        Numero = numero;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }

    // get = obtem o valor 
    // public double getSaldo()
    // {
    //     return saldo;
    // }

    // set = alterar o valor
    // public void setSaldo(double valor)
    // {
    //     saldo = valor;
    // }
}
