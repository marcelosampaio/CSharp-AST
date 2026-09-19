namespace CSharpAST02;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine() ?? "";

        Tradutor tradutor = new Tradutor();

        string nomeCifrado = tradutor.Cifrar(nome);

        Console.WriteLine($"Nome cifrado: {nomeCifrado}");
    }
}