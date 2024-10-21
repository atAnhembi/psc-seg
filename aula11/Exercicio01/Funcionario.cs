using System;

namespace Exercicio01;

public class Funcionario
{
    // construção default = padrão
    // public Funcionario() {}

    public Funcionario(string nome) {
        Nome = nome;
    }

    // polimosfismo: overload = mais de um comportamento
    // para o mesmo método.
    // Pelo menos 1 parâmetro diferente
    public Funcionario(string nome, int horasTrabalhadas) {
        Nome = nome;
        HorasTrabalhadas = horasTrabalhadas;
    }

    public string Nome { get; set; }
    public int HorasTrabalhadas { get; set; }
    public double ValorPorHora { get; set; }

    public virtual double SalarioMensal() {
        return HorasTrabalhadas * ValorPorHora;
    }

    public virtual void Imprimir() {
        System.Console.WriteLine("Funcionário: " + Nome);
    }

}
