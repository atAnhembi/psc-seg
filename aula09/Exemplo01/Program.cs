using Exemplo01;

class Program
{
    // método principal = ponto de entrada (início da execução)
    public static void Main(string[] args) {
        Pessoa p; // definindo que 'pessoa' é do TIPO Pessoa
        Pessoa p2;

        p = new Pessoa(); // cria um objeto do TIPO Pessoa
        p2 = new Pessoa();

        p.nome = "Emerson";
        p2.nome = "Paduan";

        p2 = p; // Não copia o objeto, mas sim, troca para onde o P2 está "apontando"
        p.nome = "Santos"; // troca o conteúdo do objeto, e por isso p e p2 mostram a mudança

        p.apresentar();
        p2.apresentar();
    }
}
