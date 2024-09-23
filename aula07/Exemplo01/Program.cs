
// int[] idades = [18, 20, 81, 34, 52];

int[] idades; // declara idades como um 'vetor'

idades = new int[5]; // cria (instancia) o vetor

// int[] idades = new int[5]; // simplificando em uma linha

idades[0] = 18;
idades[1] = 20;
idades[2] = 81;
idades[3] = 34;
idades[4] = 52;

// i = index
for (int i = 0; i < idades.Length; i++) // idades.Length = 5 (tamanho do vetor)
{
    System.Console.WriteLine(idades[i]);
}