namespace CSharpAT12;

public class GestorArquivo
{
    private const string NomeArquivo = "contatos.txt";

    public void SalvarContato(Contato contato)
    {
        using (StreamWriter writer = new StreamWriter(NomeArquivo, true))
        {
            writer.WriteLine($"{contato.Nome},{contato.Telefone},{contato.Email}");
        }
    }

    public List<Contato> LerContatos()
    {
        List<Contato> contatos = new List<Contato>();

        if (!File.Exists(NomeArquivo))
        {
            return contatos;
        }

        using (StreamReader reader = new StreamReader(NomeArquivo))
        {
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(linha))
                {
                    continue;
                }

                string[] partes = linha.Split(',');
                if (partes.Length == 3)
                {
                    contatos.Add(new Contato(partes[0], partes[1], partes[2]));
                }
            }
        }

        return contatos;
    }
}