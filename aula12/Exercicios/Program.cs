
// Ler 9 valores digitados pelo usuário e armazenar em uma matriz 3 x 3

int[,] numeros = new int[3, 3];
int cont = 1;

// Entrada de dados
for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        // System.Console.WriteLine("Digite o valor da posição: "+ linha + "," + coluna);
        System.Console.WriteLine(String.Format("Digite o {2}º valor, posição: ({0},{1})", linha, coluna, cont));
        numeros[linha, coluna] = int.Parse(Console.ReadLine());
        cont++;
    }
    
}

// Exibir a matriz
for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        System.Console.Write(numeros[linha, coluna] + " ");
    }
    System.Console.WriteLine();
}

// Exiba a soma de todos os valores da matriz
int soma = 0;

for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        soma = soma + numeros[linha, coluna];
    }
}
System.Console.WriteLine(String.Format("A soma vale: {0}", soma));

// fazer a soma para cada linha
for (int linha = 0; linha < 3; linha++)
{
    soma = 0;
    for (int coluna = 0; coluna < 3; coluna++)
    {
        soma = soma + numeros[linha, coluna];
    }
    System.Console.WriteLine(String.Format("A soma da linha {0} vale: {1}", linha, soma));
}

// fazer a soma para cada coluna
for (int coluna = 0; coluna < 3; coluna++)
{
    soma = 0;
    for (int linha = 0; linha < 3; linha++)
    {
        soma = soma + numeros[linha, coluna];
    }
    System.Console.WriteLine(String.Format("A soma da coluna {0} vale: {1}", coluna, soma));
}

