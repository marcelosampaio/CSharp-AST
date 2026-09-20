namespace CSharpAT08;

public class Gerente : Funcionario
{
    private const decimal PercentualBonus = 0.20m; // 20% de bônus

    public Gerente(string nome, string cargo, decimal salarioBase) 
        : base(nome, cargo, salarioBase)
    {
    }
    
    public override decimal CalcularSalarioFinal()
    {
        return SalarioBase + (SalarioBase * PercentualBonus);
    }
}