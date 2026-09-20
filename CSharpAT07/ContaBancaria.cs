namespace CSharpAT07;

public class ContaBancaria
{
    private string titular;
    private decimal saldo;

    public ContaBancaria(string titular)
    {
        this.titular = titular;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor do depósito deve ser positivo!");
            return;
        }

        saldo += valor;

        Console.WriteLine($"Depósito de {valor:C2} realizado com sucesso!");
    }

    public void Sacar(decimal valor)
    {
        if (valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque!");
            return;
        }

        saldo -= valor;

        Console.WriteLine($"Saque de {valor:C2} realizado com sucesso!");
    }

    public string getTitular()
    {
        return titular;
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: {saldo:C2}");
    }
}