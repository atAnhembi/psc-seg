
string senha;
string resultado;

// Entrada de dados
Console.WriteLine("Digite a sua senha:");
senha = Console.ReadLine();

// processamento
if(senha == "R10p5") // se a variável 'senha' é igual à "R10p5"
{
    resultado = "Acesso permitido";
}
else 
{
    resultado = "Acesso negado";
}

// saída 
System.Console.WriteLine(resultado);