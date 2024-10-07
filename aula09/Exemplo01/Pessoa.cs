using System;

namespace Exemplo01;

// a classe é um MODELO
public class Pessoa
{
    // propriedades / atributos = características
    public string nome;

    // métodos = ações
    public void apresentar() {
        Console.WriteLine("Bom dia! Eu sou " + nome);
    }

}
