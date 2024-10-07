using Exercicio;

class Program
{
    public static void Main() {
        Livro livro = new ("Programando com C#", "Deitel", 765);

        livro.Preco = -300;

        System.Console.WriteLine("Livro: ");
        System.Console.WriteLine(livro.Titulo);
        System.Console.WriteLine(livro.Autor);
        System.Console.WriteLine(livro.NumeroPaginas);
        System.Console.WriteLine(livro.Preco);
    }
}
