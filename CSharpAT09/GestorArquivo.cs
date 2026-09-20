using System.IO;
using System.Globalization;

namespace CSharpAT09;

public class GestorArquivo
{
    private const string NomeArquivo = "estoque.txt";
    
    public void SalvarProduto(Produto produto)
    {
        using (StreamWriter writer = new StreamWriter(NomeArquivo, true))
        {
            writer.WriteLine($"{produto.Nome},{produto.Quantidade},{produto.Preco.ToString(CultureInfo.InvariantCulture)}");
        }
    }
    
    public List<Produto> LerProdutos()
    {
        List<Produto> produtos = new List<Produto>();

        if (!File.Exists(NomeArquivo))
        {
            return produtos;
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
                    string nome = partes[0];
                    int quantidade = int.Parse(partes[1]);
                    decimal preco = decimal.Parse(partes[2], CultureInfo.InvariantCulture);

                    produtos.Add(new Produto(nome, quantidade, preco));
                }
            }
        }

        return produtos;
    }
}