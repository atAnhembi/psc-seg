using JogoVelha;

class Program
{
    public static void Main() {

        Jogo jogo = new ();

        bool fimDeJogo = false;

        while(!fimDeJogo) {
            jogo.Mostrar();

            System.Console.WriteLine("Digite a posição: ");
            int posicao = int.Parse(Console.ReadLine());

            jogo.Jogada(posicao);
            
            fimDeJogo = jogo.verificaFimDeJogo();

        }
    }
}
