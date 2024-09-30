//  entrada de dados e processamento
int lado;
int[] dado = new int[6];

do
{
    System.Console.WriteLine("Digite o lado sorteado: (-1 para terminar): ");
    lado = Convert.ToInt32(Console.ReadLine());
    if (lado > 0 && lado < 7)
    {
        dado[lado - 1]++;
    }
    else
    {
        if(lado != -1)
            System.Console.WriteLine("Valor inválido.");
    }

} while (lado != -1);

// saída
for (int i = 0; i < dado.Length; i++)
{
    System.Console.Write($"lado {i + 1} sorteado {dado[i]} veze(s)");
}
