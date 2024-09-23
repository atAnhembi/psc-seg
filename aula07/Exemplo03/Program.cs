
const int numeroCarros = 3;

string[] carros = new string[numeroCarros];

// entrada de dados:
for (int i = 0; i < numeroCarros; i++)
{
    System.Console.WriteLine($"Digite a placa do carro: {i+1}");
    carros[i] = Console.ReadLine();
}

System.Console.WriteLine("Ordem de saída:");
for (int i = carros.Length -1; i >= 0; i--)
{
    System.Console.WriteLine(carros[i]);
}