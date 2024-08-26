
double nota1, nota2, media;
string entrada;

Console.WriteLine("Digite a primeira nota do aluno:");
entrada = Console.ReadLine();
nota1 = Convert.ToDouble(entrada);

Console.WriteLine("Digite a segunda nota do aluno:");
entrada = Console.ReadLine();
nota2 = Convert.ToDouble(entrada);

media = (nota1 + nota2) / 2;

if (media >= 6)
{
    Console.WriteLine($"Aprovado com média {media}!");
    Console.WriteLine("Parabéns!");
}
else
{
    Console.WriteLine($"Reprovado com média {media}");
    Console.WriteLine("Tente novamente!");
}

Console.WriteLine("Fim do programa");