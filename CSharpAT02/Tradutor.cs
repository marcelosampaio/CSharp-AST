namespace CSharpAST02;

public class Tradutor
{
    public string Cifrar(string texto)
    {
        char[] caracteres = texto.ToCharArray();

        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = DeslocarCaractere(caracteres[i]);
        }

        return new string(caracteres);
    }

    private char DeslocarCaractere(char caractere)
    {
        if (caractere >= 'a' && caractere <= 'z')
        {
            return (char)('a' + (caractere - 'a' + 2) % 26);
        }

        if (caractere >= 'A' && caractere <= 'Z')
        {
            return (char)('A' + (caractere - 'A' + 2) % 26);
        }

        return caractere;
    }
}