using ExercicioCarros;

class Program
{
    public static void Main() {
        
        Carro carro1 = new("Fiat ", "Palio", 7);
        Carro carro2 = new("Fiat ", "Palio", 10, 2, 0);

        carro1.Abastecer(25);
        carro2.Andar(30);
        
        System.Console.WriteLine(carro1.Exibir());
        System.Console.WriteLine(carro2.Exibir());

    }
}