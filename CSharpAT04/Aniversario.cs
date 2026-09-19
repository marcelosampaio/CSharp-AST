namespace CSharpAT04;

public class Aniversario
{
    private readonly DateTime dataNascimento;

    public Aniversario(DateTime dataNascimento)
    {
        this.dataNascimento = dataNascimento;
    }

    public int CalcularDiasAteProximoAniversario()
    {
        DateTime hoje = DateTime.Today;
        DateTime proximoAniversario = ObterProximoAniversario(hoje);

        return (proximoAniversario - hoje).Days;
    }

    private DateTime ObterProximoAniversario(DateTime hoje)
    {
        int ano = hoje.Year;

        if (dataNascimento.Month == 2 && dataNascimento.Day == 29)
        {
            while (!DateTime.IsLeapYear(ano))
            {
                ano++;
            }
        }

        DateTime proximoAniversario = new DateTime(
            ano,
            dataNascimento.Month,
            dataNascimento.Day);

        if (proximoAniversario < hoje)
        {
            ano++;

            if (dataNascimento.Month == 2 && dataNascimento.Day == 29)
            {
                while (!DateTime.IsLeapYear(ano))
                {
                    ano++;
                }
            }

            proximoAniversario = new DateTime(
                ano,
                dataNascimento.Month,
                dataNascimento.Day);
        }

        return proximoAniversario;
    }
}