using Exemplo03;

class Program
{
    public static void Main() {
        // Conta c = new Conta();
        Conta c = new("1234-5"); // c.numero = "1234-5";
        
        // c.saldo = 1000; proibido pois saldo é privado
        // c.numero = "99999";não é possível pois não temos o Set

        c.Depositar(-1000);
        // c.Saldo = 500; // não foi fornecido um método set

        System.Console.WriteLine("Saldo: " + c.Saldo);

    }
}