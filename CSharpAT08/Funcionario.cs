namespace CSharpAT08;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public decimal SalarioBase { get; set; }

    protected Funcionario(string nome, string cargo, decimal salarioBase)
    {
        Nome = nome;
        Cargo = cargo;
        SalarioBase = salarioBase;
    }

    // Método virtual para o cálculo do salário (pode ser sobrescrito pelas subclasses)
    public virtual decimal CalcularSalarioFinal()
    {
        return SalarioBase;
    }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Funcionário: {Nome} | Cargo: {Cargo} | Salário Final: {CalcularSalarioFinal():C2}");
    }
}