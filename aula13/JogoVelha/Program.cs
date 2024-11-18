using JogoVelha;

class Program
{
    public static void Main()
    {

        Jogo jogo = new();

        bool fimDeJogo = false;
        string entrada;

        while (!fimDeJogo)
        {
            jogo.Mostrar();

            System.Console.WriteLine("Digite a posição(-1 para sair): ");

            do
            {
                entrada = Console.ReadLine();
            } while (entrada == null || entrada.Length == 0);

            if (entrada == "-1")
            {
                break;
            }
            int posicao = int.Parse(entrada);

            jogo.Jogada(posicao);

            fimDeJogo = jogo.VerificaFimDeJogo();

        }
        System.Console.WriteLine("Fim de jogo");
    }
}
