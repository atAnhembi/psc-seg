/*

Problema: ler um conjunto de notas e nomes de um grupo de alunos,
calcular a média da turma e exibir os nomes dos alunos 
que estiverem acima da média

*/

// 1. Entrada de dados
const int numeroDeAlunos = 3;

double nota, media;
double[] notas = new double[numeroDeAlunos];
string[] nomes = new string[numeroDeAlunos];

media = 0;
for (int i = 0; i < numeroDeAlunos; i++)
{
    System.Console.Write($"Digite o nome do {i + 1}º aluno: ");
    nomes[i] = Console.ReadLine();
    System.Console.Write("Digite a nota: ");
    nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
    media = media + nota;
}

// 2. Processamento
media = media / numeroDeAlunos;


// 3. Saída
System.Console.WriteLine($"Alunos acima da média ({media}):");
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] > media)
    {
        System.Console.WriteLine($"{nomes[i]} - {notas[i]}");
    }
}

