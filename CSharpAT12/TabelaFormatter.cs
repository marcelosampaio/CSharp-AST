using System;
using System.Collections.Generic;

namespace CSharpAT12;

public class TabelaFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        string linhaDivisoria = "----------------------------------------";
        Console.WriteLine(linhaDivisoria);
        Console.WriteLine("| Nome | Telefone | Email |");
        Console.WriteLine(linhaDivisoria);
        foreach (var c in contatos)
        {
            Console.WriteLine($"| {c.Nome} | {c.Telefone} | {c.Email} |");
        }
        Console.WriteLine(linhaDivisoria);
    }
}