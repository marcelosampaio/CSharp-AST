using System;

namespace CSharpAT10;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 51);
        int maxTentativas = 5;
        bool acertou = false;

        Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===");
        Console.WriteLine("Adivinhe o número secreto entre 1 e 50.");
        Console.WriteLine($"Você tem {maxTentativas} tentativas.\n");

        for (int tentativa = 1; tentativa <= maxTentativas; tentativa++)
        {
            Console.Write($"Tentativa {tentativa} de {maxTentativas} - Digite seu palpite: ");

            try
            {
                int palpite = int.Parse(Console.ReadLine());
                
                if (palpite < 1 || palpite > 50)
                {
                    Console.WriteLine("Erro: O número deve estar estritamente entre 1 e 50!\n");
                    tentativa--; // Decrementa para não penalizar o usuário com uma tentativa perdida
                    continue;
                }
                
                if (palpite == numeroSecreto)
                {
                    Console.WriteLine($"\nParabéns! Você acertou o número {numeroSecreto} em {tentativa} tentativa(s)!");
                    acertou = true;
                    break;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Dica: O número secreto é MAIOR do que o seu palpite.\n");
                }
                else
                {
                    Console.WriteLine("Dica: O número secreto é MENOR do que o seu palpite.\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida! Digite apenas números inteiros.\n");
                tentativa--;
            }
        }
        
        if (!acertou)
        {
            Console.WriteLine($"\nGame Over! Suas tentativas acabaram. O número secreto era: {numeroSecreto}");
        }
    }
}