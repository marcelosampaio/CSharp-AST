namespace CSharpAT03;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double numero1 = LerNumero();

        Console.Write("Digite o segundo número: ");
        double numero2 = LerNumero();

        Console.WriteLine("\nEscolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.Write("Opção: ");

        int operacao = LerOperacao();

        Calculadora calculadora = new Calculadora();

        try
        {
            double resultado = calculadora.Calcular(numero1, numero2, operacao);
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException excecao)
        {
            Console.WriteLine(excecao.Message);
        }
    }

    private static double LerNumero()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                return numero;
            }

            Console.Write("Número inválido. Digite novamente: ");
        }
    }

    private static int LerOperacao()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int operacao)
                && operacao >= 1
                && operacao <= 4)
            {
                return operacao;
            }

            Console.Write("Opção inválida. Digite 1, 2, 3 ou 4: ");
        }
    }
}