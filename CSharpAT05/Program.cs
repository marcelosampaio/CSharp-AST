namespace CSharpAT05;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dataFormatura = new DateTime(2027, 7, 30);

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

        if (formatura.JaPassou(dataAtual))
        {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
        }
        else if (formatura.EHoje(dataAtual))
        {
            Console.WriteLine("A data da formatura é hoje!");
        }
        else
        {
            Console.WriteLine("A formatura ainda não chegou.");
        }
    }
}