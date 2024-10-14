class CelularPrePago
{
    const double ValorPorLigacao = 0.75;

    public CelularPrePago(string cliente, string numero)
    {
        cliente = cliente.Trim();
        if (cliente.Length > 0)
            Cliente = cliente;
        else
            Cliente = "Não cadastrado";
        numero = numero.Trim();
        if (numero.Length > 0)
            Numero = numero;
        else
            Numero = "(xx) xxxxx-xxxx";
    }
    public CelularPrePago(string cliente, string numero, double saldo)
    {
        cliente = cliente.Trim();
        if (cliente.Length > 0)
            Cliente = cliente;
        else
            Cliente = "Não cadastrado";
        numero = numero.Trim();
        if (numero.Length > 0)
            Numero = numero;
        else
            Numero = "(xx) xxxxx-xxxx";
        if(saldo > 0) {
            Saldo = saldo;
        }
    }

    public string Cliente { get; }
    public string Numero { get; }

    public double Saldo { get; private set; }

    public void FazerLigacao()
    {
        if (Saldo > ValorPorLigacao)
        {
            Saldo -= ValorPorLigacao;
        }
    }

    public void FazerLigacao(int minutos)
    {
        if (minutos > 0)
        {
            if (Saldo > ValorPorLigacao * minutos)
            {
                Saldo -= ValorPorLigacao * minutos;
            }
        }
    }

    public void Recarregar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }

    public String Exibir() {
        return "Telefone: " + Numero + " cliente: " + Cliente + " saldo: R$ " + Saldo;
    }
}