class Personagem
{
    public string Nome { get; set; }

    // virtual = permite a alteração do comportamento na classe filha
    // abstract = obrigatório a implementação do comportamento na classe filha
    public virtual void Apresentar()
    {
        System.Console.WriteLine("Olá! Sou " + Nome);
    }
}

class Heroi : Personagem
{
    public string Poder { get; set; }

    // polimorfismo: mudança no comportamento da classe base
    public override void Apresentar() // overrride sobrescreve o comportamento original, definido como virtual
    {
        System.Console.WriteLine("AH!!!! " + Nome + " Poder: " + Poder);
    }
}

class SuperHeroi : Heroi
{
}

class Program
{
    public static void Main()
    {
        Heroi heroi = new();
        SuperHeroi superHeroi = new();

        heroi.Nome = "Heroi";
        heroi.Poder = "Voar";
        heroi.Apresentar();

        superHeroi.Nome = "Superheroi";
        superHeroi.Poder = "Atira fogo";
        superHeroi.Apresentar();

    }
}