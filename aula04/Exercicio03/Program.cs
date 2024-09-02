int numero;
int contador;
int soma;

contador = 1;
soma = 0;

while (contador <= 10)
{
    System.Console.WriteLine("Digite o número:");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero % 2 == 0) // se o resto da divisão for 0
    {
        System.Console.WriteLine("par");
    }
    soma = soma + numero;
    contador++;
}

System.Console.WriteLine($"A soma vale: {soma}");
System.Console.WriteLine($"A média vale: {soma / 10.0}");
