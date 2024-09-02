int contador;
int limite;
string entrada;

System.Console.WriteLine("Informe o limite:");
entrada = Console.ReadLine();

limite = Convert.ToInt32(entrada);

contador = 1;

while (contador <= limite)
{
    System.Console.Write($"{contador} ");
    contador++;
}
