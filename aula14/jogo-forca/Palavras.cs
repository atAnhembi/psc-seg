using System;

namespace jogo_forca;

public class Palavras
{
    private string[] palavras = {"azul", "abacate", "unit"};

    public string ProximaPalavra() {
        Random random = new ();

        int proxima = random.Next(palavras.Length);
        return palavras[proxima];
    }
}
