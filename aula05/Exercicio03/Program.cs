
int secreto, chute;

Random geradorAleatorio  = new (); // criando um gerador de números "aleatórios"

secreto = geradorAleatorio.Next(1, 11); // geara um número entre 1 e 10
chute = 0;

while (chute != secreto)
{
    System.Console.WriteLine("tente acertar o número secreto:");
    chute = Convert.ToInt32(Console.ReadLine());

    if (chute == secreto)
    {
        System.Console.WriteLine("Acertou! Parabéns!");
    }
    else
    {
        if (chute < secreto)
        {
            System.Console.WriteLine("O número secreto é maior");
        }
        else
        {
            System.Console.WriteLine("O número secreto é menor");
        }
    }
}