// lina x coluna

int[,] numeros = new int[3, 3];

// linha 1, coluna 1
numeros[1, 1] = 5;

int[,] valores = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

// exibir os valores da primeira linha da matriz
// System.Console.WriteLine(valores[0,0]);
// System.Console.WriteLine(valores[0,1]);
// System.Console.WriteLine(valores[0,2]);
// for (int coluna = 0; coluna < 3; coluna++)
// {
//     System.Console.WriteLine(valores[0, coluna]);
// }

// exibir os valores da segunda linha da matriz
// System.Console.WriteLine(valores[1,0]);
// System.Console.WriteLine(valores[1,1]);
// System.Console.WriteLine(valores[1,2]);
// for (int coluna = 0; coluna < 3; coluna++)
// {
//     System.Console.WriteLine(valores[1, coluna]);
// }

// exibir os valores da terceira linha da matriz
// System.Console.WriteLine(valores[2,0]);
// System.Console.WriteLine(valores[2,1]);
// System.Console.WriteLine(valores[2,2]);
// for (int coluna = 0; coluna < 3; coluna++)
// {
//     System.Console.WriteLine(valores[2, coluna]);
// }


for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        System.Console.Write(valores[linha, coluna] + " ");
    }
    System.Console.WriteLine();
}