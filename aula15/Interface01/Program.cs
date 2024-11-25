using Interface01;

class Program
{
    public static void Main() {
        // IMotor aviao = new Aviao();
        // IMotor carro = new Carro();

        IMotor[] veiculos  = new IMotor[2];

        veiculos[0] = new Aviao();
        veiculos[1] = new Carro();

        foreach (var veiculo in veiculos)
        {
            veiculo.Ligar();
        }

    }
}