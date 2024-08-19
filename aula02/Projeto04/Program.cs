int idade;
string nome;
string entrada;

Console.WriteLine("Informe o seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Informe a sua idade");
entrada = Console.ReadLine();

idade = Convert.ToInt32(entrada);

Console.WriteLine($"Olá {nome}! Você tem {idade} anos.");
