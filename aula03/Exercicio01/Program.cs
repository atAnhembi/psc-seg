
double nota1, nota2, media, exame;
int faltas;

System.Console.WriteLine("Digite a quantidade de faltas:");
faltas = Convert.ToInt32(Console.ReadLine());

if(faltas >= 16)
{
    System.Console.WriteLine("Reprovado por faltas.");
}
else 
{
    System.Console.WriteLine("Digite a primeira nota:");
    nota1 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Digite a segunda nota:");
    nota2 = Convert.ToDouble(Console.ReadLine());

    media = (nota1 + nota2) / 2;

    if(media >= 6)
    {
        System.Console.WriteLine("Aluno(a) aprovado(a)");
    }
    else 
    {
        System.Console.WriteLine("Digite a nota do exame");
        exame = Convert.ToDouble(Console.ReadLine());

        media = (exame + media) / 2;
        
        if(media >= 5)
        {
            System.Console.WriteLine("Aprovado no exame");
        }
        else
        {
            System.Console.WriteLine("Reprovado por nota");
        }
    }
}
System.Console.WriteLine("Fim do programa");