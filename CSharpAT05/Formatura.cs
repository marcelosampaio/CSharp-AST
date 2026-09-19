namespace CSharpAT05;

public class Formatura
{
    private readonly DateTime dataFormatura;

    public Formatura(DateTime dataFormatura)
    {
        this.dataFormatura = dataFormatura;
    }

    public bool JaPassou(DateTime dataAtual)
    {
        return dataAtual > dataFormatura;
    }

    public bool EHoje(DateTime dataAtual)
    {
        return dataAtual == dataFormatura;
    }
}