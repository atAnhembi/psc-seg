// int idade;
// string entrada;

// Console.WriteLine("Digite a sua idade:");
// entrada = Console.ReadLine();

// // Console.WriteLine("Sua idade é " + entrada);
// // Console.WriteLine("Sua idade é {0}", entrada);
// Console.WriteLine($"Sua idade é {entrada}");

// // transforma o texto do entrada para um número inteiro
// // e armazena em idade
// idade = Convert.ToInt32(entrada);

// Console.WriteLine($"Sua idade é {idade}");

// ------
int valorInteiro = 9;
double valorDecimal= 10.5;

// Converter de inteiro para decimal, é implícito
// Não precisa usar o Convert
// valorDecimal = valorInteiro;

// Converte para Inteiro, um número decimal
// (10.5 ==> 10)
valorInteiro = Convert.ToInt32(valorDecimal);

Console.WriteLine(valorDecimal);
Console.WriteLine(valorInteiro);



