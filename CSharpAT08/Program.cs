namespace CSharpAT08;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE GESTÃO DE FUNCIONÁRIOS ===\n");

        // Criando objetos usando polimorfismo
        Funcionario funcionarioComum = new Analista("Ana Souza", "Analista de Suporte", 4000.00m);
        Funcionario gerente = new Gerente("Carlos Silva", "Gerente de Projetos", 8000.00m);

        // Exibindo os resultados
        Console.WriteLine("Dados do Funcionário Comum:");
        funcionarioComum.ExibirDados();

        Console.WriteLine("\nDados do Gerente (com 20% de bônus):");
        gerente.ExibirDados();
    }
}