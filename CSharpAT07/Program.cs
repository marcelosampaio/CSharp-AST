namespace CSharpAT07;

public class Program
{
    public static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria("Marcelo Sampaio");

        Console.WriteLine($"Titular: {conta.getTitular()}");

        conta.Depositar(500);
        conta.ExibirSaldo();

        Console.WriteLine("Tentativa de saque: R$ 700,00");
        conta.Sacar(700);

        conta.Sacar(200);
        conta.ExibirSaldo();
    }
}