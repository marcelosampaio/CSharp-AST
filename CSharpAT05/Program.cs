namespace CSharpAT05;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dataFormatura = new DateTime(2026, 12, 15);

        Formatura formatura = new Formatura(dataFormatura);

        Console.Write("Digite a data atual (dd/MM/yyyy): ");

        DateTime dataAtual;

        while (!DateTime.TryParse(Console.ReadLine(), out dataAtual))
        {
            Console.Write("Data inválida. Digite novamente (dd/MM/yyyy): ");
        }

        if (dataAtual > DateTime.Today)
        {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            return;
        }

        Console.WriteLine($"Data informada: {dataAtual:dd/MM/yyyy}");
    }
}