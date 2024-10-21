using System;

namespace Exercicio01;

public class FuncionarioSenior : Funcionario
{
    public double Bonus;
    public FuncionarioSenior(string nome, double  bonus):base(nome){
        Bonus = bonus;
    }
    
    public override double SalarioMensal() {
        // base: se refere à classe base. Portanto,
        // chama co SalarioMensal da classe base
        return base.SalarioMensal() + 
            Bonus * (HorasTrabalhadas / 10);
    }

    public override void Imprimir() {
        System.Console.WriteLine("Senior: " + Nome);
    }
}
