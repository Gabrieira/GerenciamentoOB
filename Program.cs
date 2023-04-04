using System;
using System.Globalization;

namespace csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bancaTotal, valorOperacao, gain;
            int payout;
            char resposta;

            Console.Write("Digite o valor da sua banca: R$");
            bancaTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o PAYOUT atual: ");
            payout = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da sua operação: R$");
            valorOperacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Sua operação foi (G)ain ou (L)oss?");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 'G')
            {
                gain = (payout * valorOperacao)/100;
                Console.WriteLine($"Você ganhou :" + gain.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"Sua banca ficou com um total de {gain+bancaTotal}");

            } 
            if (resposta == 'L')
            {
                Console.WriteLine($"Você perdeu: " + valorOperacao.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"Sua banca ficou com um total de {bancaTotal-valorOperacao}");
            }
        }
    }
}