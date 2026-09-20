namespace CSharpAT08;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE GESTÃO DE FUNCIONÁRIOS ===\n");
        
        Funcionario funcionarioComum = new Analista("Ana Souza", "Analista de Suporte", 4000.00m);
        Funcionario gerente = new Gerente("Carlos Silva", "Gerente de Projetos", 8000.00m);
        
        Console.WriteLine("Dados do Funcionário Comum:");
        funcionarioComum.ExibirDados();

        Console.WriteLine("\nDados do Gerente (com 20% de bônus):");
        gerente.ExibirDados();
    }
}