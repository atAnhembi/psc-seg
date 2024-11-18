using System;

namespace JogoVelha;

public class Tabuleiro
{
    private const int PosicaoLivre = 0;
    private int[,] tabuleiro;
    private Jogador jogador1, jogador2;

    public Tabuleiro(Jogador jogador1, Jogador jogador2)
    {
        tabuleiro = new int[3, 3];
        this.jogador1 = jogador1;
        this.jogador2 = jogador2;
    }

    public bool Marcar(int posicao, Jogador jogador)
    {
        switch (posicao)
        {
            case 1:
                if (tabuleiro[0, 0] == PosicaoLivre)
                {
                    tabuleiro[0, 0] = jogador.Numero;
                    return true;
                }
                return false;
            case 2:
                if (tabuleiro[0, 1] == PosicaoLivre)
                {
                    tabuleiro[0, 1] = jogador.Numero;
                    return true;
                }
                return false;
            case 3:
                if (tabuleiro[0, 2] == PosicaoLivre)
                {
                    tabuleiro[0, 2] = jogador.Numero;
                    return true;
                }
                return false;
            case 4:
                if (tabuleiro[1, 0] == PosicaoLivre)
                {
                    tabuleiro[1, 0] = jogador.Numero;
                    return true;
                }
                return false;
            case 5:
                if (tabuleiro[1, 1] == PosicaoLivre)
                {
                    tabuleiro[1, 1] = jogador.Numero;
                    return true;
                }
                return false;
            case 6:
                if (tabuleiro[1, 2] == PosicaoLivre)
                {
                    tabuleiro[1, 2] = jogador.Numero;
                    return true;
                }
                return false;
            case 7:
                if (tabuleiro[2, 0] == PosicaoLivre)
                {
                    tabuleiro[2, 0] = jogador.Numero;
                    return true;
                }
                return false;
            case 8:
                if (tabuleiro[2, 1] == PosicaoLivre)
                {
                    tabuleiro[2, 1] = jogador.Numero;
                    return true;
                }
                return false;
            case 9:
                if (tabuleiro[2, 2] == PosicaoLivre)
                {
                    tabuleiro[2, 2] = jogador.Numero;
                    return true;
                }
                return false;

            default: return false;
        }
    }

    public void Exibir()
    {
        int cont = 1;
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (tabuleiro[linha, coluna] == 0)
                    System.Console.Write(cont + " ");
                else
                if (tabuleiro[linha, coluna] == jogador1.Numero)
                    System.Console.Write(jogador1.Nome + " ");
                else
                    System.Console.Write(jogador2.Nome + " ");
                cont++;
            }
            System.Console.WriteLine();
        }
    }

    public bool ExistePosicaoLivre()
    {
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (tabuleiro[linha, coluna] == PosicaoLivre)
                    return true;
            }
        }
        return false;
    }

    public Jogador VerificaLinhasIguais()
    {
        for (int linha = 0; linha < 3; linha++)
        {
            if (tabuleiro[linha, 0] != PosicaoLivre &&
                tabuleiro[linha, 0] == tabuleiro[linha, 1] &&
                tabuleiro[linha, 1] == tabuleiro[linha, 2])
            {
                if (tabuleiro[linha, 1] == jogador1.Numero)
                    return jogador1;
                else
                    return jogador2;
            }


        }
        return null;
    }
    public Jogador VerificaColunasIguais()
    {
        for (int coluna = 0; coluna < 3; coluna++)
        {
            if (tabuleiro[0, coluna] != PosicaoLivre &&
                tabuleiro[0, coluna] == tabuleiro[1, coluna] &&
                tabuleiro[1, coluna] == tabuleiro[2, coluna])
            {
                if (tabuleiro[0, coluna] == jogador1.Numero)
                    return jogador1;
                else
                    return jogador2;
            }


        }
        return null;
    }
    public Jogador VerificarDiagonalPrincipal() {
        if (tabuleiro[0, 0] != PosicaoLivre &&
                tabuleiro[0, 0] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 2])
            {
                if (tabuleiro[0, 0] == jogador1.Numero)
                    return jogador1;
                else
                    return jogador2;
            }
            return null;
    }


        public Jogador VerificarDiagonalSecundaria() {
        if (tabuleiro[0, 2] != PosicaoLivre &&
                tabuleiro[0, 2] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 0])
            {
                if (tabuleiro[0, 2] == jogador1.Numero)
                    return jogador1;
                else
                    return jogador2;
            }
            return null;
    }

}
