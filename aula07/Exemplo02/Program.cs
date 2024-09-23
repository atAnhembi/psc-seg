/*

Problema: ler um conjunto de notas de um grupo de alunos,
calcular a média da turma e exibir as notas que estiverem acima da média

*/


// 1. Entrada de dados
const int numeroDeAlunos = 3;

double nota, media;
double[] notas = new double[numeroDeAlunos];

media = 0;
for (int i = 0; i < numeroDeAlunos; i++)
{
    System.Console.Write($"Digite a {i + 1}ª nota: ");
    nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
    media = media + nota;
}

// 2. Processamento
media = media / numeroDeAlunos;


// 3. Saída
System.Console.WriteLine($"Notas acima da média ({media}):");
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] > media)
    {
        System.Console.WriteLine($"{notas[i]}");
    }
}