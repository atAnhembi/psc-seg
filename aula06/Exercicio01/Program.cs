
// Escreva um programa que leia 10 números inteiros e exiba quantos são pares e quantos são ímpares.

int numero;
int cont;
int impares;
const int totalNumeros = 10;

impares = 0;
for (cont = 1; cont <= totalNumeros ; cont++)
{
    System.Console.WriteLine($"Digite o próximo valor inteiro ({cont}/{totalNumeros}):");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero % 2 == 1)
    {
        impares++;
    }
}
System.Console.WriteLine($"Foram digitados {impares} número(s) impar(es)");
System.Console.WriteLine($"Foram digitados {totalNumeros - impares} número(s) par(es)");
