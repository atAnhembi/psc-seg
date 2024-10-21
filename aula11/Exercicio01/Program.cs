
namespace Exercicio01;

class Program
{
    public static void Main()
    {
        Funcionario funcionario = new ("Carlos da Silva", 100);

        funcionario.ValorPorHora = 50;
        // funcionario.HorasTrabalhadas = 100;

        funcionario.Imprimir();
        System.Console.WriteLine("Salário: " + funcionario.SalarioMensal());

        FuncionarioSenior senior = new ("João Benedito", 20);
        senior.HorasTrabalhadas = 14;
        senior.ValorPorHora = 50;

        senior.Imprimir();
        System.Console.WriteLine(senior.SalarioMensal());
    }
}