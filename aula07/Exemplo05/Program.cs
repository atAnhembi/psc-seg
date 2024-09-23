
double[] notas = [6, 5, 7];
string[] nomes = ["Ana", "Carlos", "Ricardo"];

string nomeProcurado;

System.Console.WriteLine("Informe o nome do aluno: ");
nomeProcurado = Console.ReadLine();

// procurar o nome do aluno e, se encontrar mostra a nota
//  se não encontrar, informe que o nome não foi achado

bool achou = false;

for (int i = 0; i < nomes.Length; i++)
{
    if (nomeProcurado.Equals(nomes[i]))
    {
        System.Console.WriteLine($"A nota do {nomeProcurado} é {notas[i]}");
        achou = true;
    }
}

if (!achou)
{
    System.Console.WriteLine("Aluno não encontrado");
}