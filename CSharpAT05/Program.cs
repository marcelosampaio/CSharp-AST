namespace CSharpAT05;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dataFormatura = new DateTime(2026, 12, 15);

        Formatura formatura = new Formatura(dataFormatura);

        Console.WriteLine("checkpoint commit");
    }
}