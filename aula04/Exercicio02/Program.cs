// Entrada
// Número digitado pelo usuário

// Processamento e saída
// Calcular e apresentar a expressão calculada

int numero;
int contador;

System.Console.WriteLine("Qual é a tabuada?");
numero = Convert.ToInt32( Console.ReadLine() );

System.Console.WriteLine($"Tabuada do {numero}");

contador = 0;
while(contador < 11) {
    System.Console.WriteLine($"{numero} x {contador:D2} = {numero * contador}");
    contador++;
}
