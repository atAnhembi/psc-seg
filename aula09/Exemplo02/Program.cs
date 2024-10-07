using Exemplo02;

class Program
{
    public static void Main() {
        // Conta c = new Conta();
        Conta c = new("1234-5"); // c.numero = "1234-5";
        
        // c.saldo = 1000; proibido pois saldo é privado
        c.numero = "99999";

        c.depositar(-1000);
        c.setSaldo(500);

        System.Console.WriteLine("Saldo: " + c.getSaldo());

    }
}
