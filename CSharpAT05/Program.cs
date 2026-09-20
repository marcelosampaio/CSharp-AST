namespace CSharpAT05;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dataFormatura = new DateTime(2027, 6, 30);

        Formatura formatura = new Formatura(dataFormatura);

        DateTime dataAtual = LerDataAtual();

        if (dataAtual > DateTime.Today)
        {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            return;
        }

        if (formatura.JaPassou(dataAtual))
        {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
            return;
        }

        if (formatura.EHoje(dataAtual))
        {
            Console.WriteLine("A data da formatura é hoje!");
            return;
        }

        TempoRestante tempoRestante = new TempoRestante(
            dataAtual,
            formatura.ObterDataFormatura());

        Console.WriteLine(
            $"Faltam {tempoRestante.ObterTempoRestanteString()} para sua formatura!");
    }

    private static DateTime LerDataAtual()
    {
        Console.Write("Digite a data atual (dd/MM/yyyy): ");

        DateTime dataAtual;

        while (!DateTime.TryParse(Console.ReadLine(), out dataAtual))
        {
            Console.Write("Data inválida. Digite novamente (dd/MM/yyyy): ");
        }

        return dataAtual;
    }
}