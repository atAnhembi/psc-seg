using System;

namespace jogo_forca;

public class Jogo
{
    private string secreta, revelada = "";
    private int tentativas;

    public Jogo(string secreta)
    {
        this.secreta = secreta;
        foreach (var letra in secreta)
        {
            revelada += "_";
        }
        tentativas = 6;
    }

    public String PalavraRevelada()
    {
        string saida = "";
        foreach (var letra in revelada)
        {
            saida += letra + " ";
        }
        return saida;
    }

    public int Tentativas()
    {
        return tentativas;
    }

    public void VerificaAcerto(char letraTentativa)
    {
        string aux = "";
        bool acertou = false;
        for (int i = 0; i < secreta.Length; i++)
        {
            if (secreta[i] == letraTentativa)
            {
                aux += letraTentativa;
                acertou = true;
            }
            else
            {
                aux += revelada[i];
            }
        }
        if (!acertou)
        {
            tentativas--;
        }
        revelada = aux;
    }

    public bool VerificarFinal()
    {
        if (tentativas == 0)
        {
            System.Console.WriteLine("Vc perdeu!");
            return true;
        }
        if (revelada.Equals(secreta))
        {
            System.Console.WriteLine("Vc acertou  a  palavra");
            return true;
        }
        return false;
    }
}
