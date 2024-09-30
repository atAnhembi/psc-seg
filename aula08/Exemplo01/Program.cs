

/*
funções
método

[retorno] nomeDoMétodo ([parâmetros])
{
    [corpo do método]
}
*/

string Saudacao(string nome, int periodo)
{
    if (periodo == 1)
        return $"Bom dia {nome}!";
    else
        if (periodo == 2)
            return $"Boa tarde {nome}!";
        else
            return $"Boa noite {nome}!";
}

string resposta;

resposta = Saudacao("Emerson", 1); // chamada de função/método
System.Console.WriteLine(resposta);

System.Console.WriteLine("Fim do programa");

resposta = Saudacao("Paduan", 3);
System.Console.WriteLine(resposta);