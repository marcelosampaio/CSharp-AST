namespace CSharpAT06;

public class Program
{
    public static void Main(string[] args)
    {
        Aluno aluno = new Aluno
        {
            Nome = "Marcelo Sampaio",
            Matricula = "202500344",
            Curso = "Análise e Desenvolvimento de Sistemas",
            MediaNotas = 8.8
        };

        aluno.ExibirDados();
    }
}