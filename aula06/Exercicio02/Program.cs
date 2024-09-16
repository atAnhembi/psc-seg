
// Faça um programa que simule o download de um arquivo, exibindo na tela a seguinte saída:

// ...........10%..........20%..........30%...........40%...........50%
// ..........60%...........70%...........80%..........90%...........100%

// System.Console.WriteLine("...........10%..........20%..........30%...........40%...........50%");

// ** solução 1 **
// for (int cont = 10; cont <= 100; cont += 10)
// {
//     System.Console.Write($"...........{cont}% ");
// }

// ** solução 2 **

// double tamanhoTotal = 1000;
// double tamanhoAtual = 0;

// while(tamanhoAtual <= tamanhoTotal) {
//     System.Console.Write($"...........{(tamanhoAtual / tamanhoTotal) * 100}% ");
//     tamanhoAtual += 100;
//     Thread.Sleep(1000);
// }

// ** solução 3 **

double tamanhoTotal = 1000;
double tamanhoAtual = 100;

System.Console.WriteLine("Iniciando o download");
while(tamanhoAtual <= tamanhoTotal) {
    int ponto = 1;
    while (ponto < 11)
    {
        System.Console.Write(".");
        Thread.Sleep(500);
        ponto++;
    }
    System.Console.Write($"{(tamanhoAtual / tamanhoTotal) * 100}% ");
    tamanhoAtual += 100;
}
