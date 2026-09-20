namespace CSharpAT05;

public class TempoRestante
{
    private readonly DateTime dataInicial;
    private readonly DateTime dataFinal;

    public TempoRestante(DateTime dataInicial, DateTime dataFinal)
    {
        this.dataInicial = dataInicial;
        this.dataFinal = dataFinal;
    }

    public int ObterAnosCompletos()
    {
        int anos = 0;
        DateTime dataCalculada = dataInicial;

        while (dataCalculada.AddYears(1) <= dataFinal)
        {
            dataCalculada = dataCalculada.AddYears(1);
            anos++;
        }

        return anos;
    }

    public int ObterMesesCompletos()
    {
        DateTime dataCalculada = dataInicial.AddYears(ObterAnosCompletos());

        int meses = 0;

        while (dataCalculada.AddMonths(1) <= dataFinal)
        {
            dataCalculada = dataCalculada.AddMonths(1);
            meses++;
        }

        return meses;
    }

    public int ObterDiasRestantes()
    {
        DateTime dataCalculada = dataInicial
            .AddYears(ObterAnosCompletos())
            .AddMonths(ObterMesesCompletos());

        return (dataFinal - dataCalculada).Days;
    }

    public string ObterTempoRestanteString()
    {
        int anos = ObterAnosCompletos();
        int meses = ObterMesesCompletos();
        int dias = ObterDiasRestantes();

        return $"{anos} anos, {meses} meses e {dias} dias";
    }
}