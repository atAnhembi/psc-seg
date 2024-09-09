
string entrada;
int maxX, maxY;
int x, y;
bool xValido, yValido;

System.Console.WriteLine("Digite o valor máximo em X");
entrada = Console.ReadLine();
maxX = Convert.ToInt32(entrada);
System.Console.WriteLine("Digite o valor máximo em Y");
entrada = Console.ReadLine();
maxY = Convert.ToInt32(entrada);

System.Console.WriteLine("Qual a coordenada X?");
entrada = Console.ReadLine();
x = Convert.ToInt32(entrada);
System.Console.WriteLine("Qual a coordenada Y?");
entrada = Console.ReadLine();
y = Convert.ToInt32(entrada);

xValido = (x >= 0) && (x <= maxX);
yValido = (y >= 0) && (y <= maxY);

if( xValido && yValido )
{
    System.Console.WriteLine("Coordenada válida");
}
else 
{
    if(!xValido)
    {
        System.Console.WriteLine("Coordenada X inválida");
    }

    if(!yValido)
    {
        System.Console.WriteLine("Coordenada Y inválida");
    }
    
}
