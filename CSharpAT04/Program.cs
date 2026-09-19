namespace CSharpAT04;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");

        DateTime dataNascimento;

        while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.Write("Data inválida. Digite novamente (dd/MM/yyyy): ");
        }

        Aniversario aniversario = new Aniversario(dataNascimento);

        int dias = aniversario.CalcularDiasAteProximoAniversario();

        Console.WriteLine($"Faltam {dias} dias para o seu próximo aniversário.");

        if (dias < 7)
        {
            Console.WriteLine("Seu aniversário está chegando!");
        }
    }
}