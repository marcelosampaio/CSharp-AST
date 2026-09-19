namespace CSharpAT03;

public class Calculadora
{
    public double Calcular(double numero1, double numero2, int operacao)
    {
        return operacao switch
        {
            1 => numero1 + numero2,
            2 => numero1 - numero2,
            3 => numero1 * numero2,
            4 => numero2 != 0
                ? numero1 / numero2
                : throw new DivideByZeroException("Não é possível dividir por zero."),
            _ => throw new ArgumentException("Operação inválida.")
        };
    }
}