/*

1. Definir uma interface chamada Andar que define o método
deslocar. Este método recebe como parâmetro a quantidade
(distancia) que o deslocamento será feito.

2. Definir 2 classes de personagens que implementam a
interface Andar e escrevem os métodos de deslocamento.

3. Aplicar em um programa dois objetos do tipo personagem
se movendo pela tela.

*/

using Exercicio01;

class Program
{
    public static void Main() 
    {
        IAndar[] personagens = [
            new Orc(), 
            new Troll(), new Orc(), new Troll()];


        foreach (var personagem in personagens)
        {
            personagem.Deslocar(5);
        }
    }
}
