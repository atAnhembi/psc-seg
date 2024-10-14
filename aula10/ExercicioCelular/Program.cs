class Program
{
    public static void Main() {
        CelularPrePago celular = new CelularPrePago("Emerson", "(11) 99999-9999");

        celular.Recarregar(50);

        celular.FazerLigacao(10);
        
        System.Console.WriteLine(celular.Exibir());
    }
}