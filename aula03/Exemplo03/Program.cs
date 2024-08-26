// Operadores aritméticos:
// + - * / %(resto)

// Operadores relacionais
// > >= < <= == (igual) != (diferente)

// Operadores lógicos
// ou (||)
// e (&&) 

/*
E = só é true se as duas condições forem true
V E V = V
V E F = F
F & V = F
F E F = F

Ou = só é false se as duas condições forem false
V Ou V = V
F Ou V = V
V ou F = V
F Ou F = F
*/
// para passar para a próxima fase, preciso de:

// condição 1: conseguir 1000 pontos
// condição 2: encontrar a chave

int pontos = 900;
bool achouChave = false;

bool condicao1 = (pontos >= 1000);
bool condicao2 = achouChave;

if(condicao1  && condicao2) {
    System.Console.WriteLine("Passou de fase!");
}
else 
{
    System.Console.WriteLine("Ainda não pode ir para a próxima fase");
}


