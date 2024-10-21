using Heranca02;

class Program
{
    public static void Main()
    {
        Figura[] figuras = new Figura[3];

        figuras[0] = new Circulo();
        figuras[1] = new Quadrado();
        figuras[2] = new Quadrado();

        foreach (Figura figura in figuras)
        {
            figura.Desenhar();
        }
        // for (int i = 0; i < figuras.Length; i++)
        // {
        //     figuras[i].Desenhar();
        // }
    }
}