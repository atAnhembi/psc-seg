using System;

namespace Exemplo02;

public class Conta(string numero)
{
    public string numero = numero;

    // Encapsulamento : esconder os atributos
    private double saldo = 0;

    public void depositar(double valor) {
        if(valor > 0)
        {
            saldo += valor;
        }
    }

    // get = obtem o valor 
    public double getSaldo() {
        return saldo;
    }

    // set = alterar o valor
    public void setSaldo(double valor) {
        saldo = valor;
    }
}
