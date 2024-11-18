// definir um conjunto de palavras para o jogo
// quantidade de tentativas

// lógica:
// - sortear uma palavra

// - exibir as indicações de letras da palavra
// - exibir a quantidade de tentativas
// - pedir a letra para o jogador

// - verificar se acertou ou errou a letra (está na palavra)

//  exibir o resultado da verificação
//  atualizar os dados do jogo
// - verificar o fim de jogo

using jogo_forca;

class Program
{
    public static void Main()
    {
        Palavras palavras = new();

        char letraTentativa;

        string secreta = palavras.ProximaPalavra();
        
        Jogo jogo = new(secreta);

        System.Console.WriteLine(secreta);

        while (!jogo.VerificarFinal())
        {
            System.Console.WriteLine(jogo.PalavraRevelada());
            System.Console.WriteLine("Tentativas restantes: " + jogo.Tentativas());

            System.Console.WriteLine("Digite a letra:");
            string entrada = Console.ReadLine();
            letraTentativa = entrada[0];

            jogo.VerificaAcerto(letraTentativa);
        }
    }
}