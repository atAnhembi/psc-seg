float massaInicial, massaFinal;
int numeroDeRepeticoes;

System.Console.WriteLine("Digite a massa inicial");
massaInicial = Convert.ToSingle(Console.ReadLine());

massaFinal = massaInicial;

numeroDeRepeticoes = 0;
while( massaFinal >= 0.5 ) // enquanto a massa for maior ou igual
{
    massaFinal = massaFinal / 2;
    // System.Console.WriteLine(massaFinal);
    numeroDeRepeticoes++;
}

int segundos = numeroDeRepeticoes * 50;
int minutos = segundos / 60;
segundos = segundos % 60; // resto da divisão por 60 (quanto sobra depois que dividi por 60)

int horas = minutos / 60;
minutos = minutos % 60;

System.Console.WriteLine($"Massa inicial: {massaInicial}g");
System.Console.WriteLine($"Massa final: {massaFinal}g");
System.Console.WriteLine($"Tempo: {horas}:{minutos}:{segundos}");