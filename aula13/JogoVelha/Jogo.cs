using System;

namespace JogoVelha;

public class Jogo
{
    Jogador jogador1;
    Jogador jogador2;

    Jogador jogadorDaVez;

    Tabuleiro tabuleiro;

    public Jogo()
    {
        jogador1 = new('X');
        jogador2 = new('O');
        jogadorDaVez = jogador1;
        tabuleiro = new(jogador1, jogador2);
    }

    public void Mostrar()
    {
        tabuleiro.Exibir();
    }

    private void ProximoJogador()
    {
        if (jogadorDaVez == jogador1)
        {
            jogadorDaVez = jogador2;
        }
        else
        {
            jogadorDaVez = jogador1;
        }
    }

    public bool Jogada(int posicao)
    {
        bool marcou = tabuleiro.Marcar(posicao, jogadorDaVez);
        if(marcou) {
            ProximoJogador();
            return true;
        }
        return false;
    }

    public bool verificaFimDeJogo() {
        // se está cheio então empate
        if(tabuleiro.ExistePosicaoLivre() == false) {
            System.Console.WriteLine("Empate");
            return true;
        }
        // se alguém ganhou:
        Jogador ganhou = tabuleiro.VerificaLinhasIguais();
        if(ganhou == null) {
            ganhou = tabuleiro.VerificaColunasIguais();
            if(ganhou == null) {
                ganhou = tabuleiro.VerificarDiagonalPrincipal();
                if(ganhou == null) {
                    ganhou = tabuleiro.VerificarDiagonalSecundaria();
                }
            }
        }
        if(ganhou != null) {
            System.Console.WriteLine("Vitoria: " + ganhou.Nome);
            return true;
        } 
        return false;
    }

   
}
