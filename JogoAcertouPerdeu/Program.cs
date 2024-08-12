using System;

class Program
{
    static void Main()
    {
        // Entrada do número neutro
        Console.Write("Jogador Neutro, escolha um número entre 1 e 100: ");
        int numeroNeutro = int.Parse(Console.ReadLine());

        // Valida se o número está dentro do intervalo permitido
        if (numeroNeutro < 1 || numeroNeutro > 100)
        {
            Console.WriteLine("Número fora do intervalo permitido.");
            return;
        }

        // Inicializa os intervalos para a busca
        int menor = 1;
        int maior = 100;

        // Jogadores tentam adivinhar o número
        bool acertou = false;
        while (!acertou)
        {
            Console.Write("\nJogador 1, tente adivinhar o número: ");
            int palpiteJogador1 = int.Parse(Console.ReadLine());

            // Verifica se o palpite está dentro do intervalo
            if (palpiteJogador1 < menor || palpiteJogador1 > maior)
            {
                Console.WriteLine($"Seu palpite deve estar entre {menor} e {maior}. Tente novamente.");
                continue;
            }

            if (palpiteJogador1 > numeroNeutro)
            {
                maior = palpiteJogador1;
                Console.WriteLine($"O número é menor que {palpiteJogador1}. O número está entre {menor} e {maior}.");
            }
            else if (palpiteJogador1 < numeroNeutro)
            {
                menor = palpiteJogador1;
                Console.WriteLine($"O número é maior que {palpiteJogador1}. O número está entre {menor} e {maior}.");
            }
            else
            {
                Console.WriteLine("Parabéns, você perdeu, Jogador 1!");
                acertou = true;
                break;
            }

            Console.Write("\nJogador 2, tente adivinhar o número: ");
            int palpiteJogador2 = int.Parse(Console.ReadLine());

            // Verifica se o palpite está dentro do intervalo
            if (palpiteJogador2 < menor || palpiteJogador2 > maior)
            {
                Console.WriteLine($"Seu palpite deve estar entre {menor} e {maior}. Tente novamente.");
                continue;
            }

            if (palpiteJogador2 > numeroNeutro)
            {
                maior = palpiteJogador2;
                Console.WriteLine($"O número é menor que {palpiteJogador2}. O número está entre {menor} e {maior}.");
            }
            else if (palpiteJogador2 < numeroNeutro)
            {
                menor = palpiteJogador2;
                Console.WriteLine($"O número é maior que {palpiteJogador2}. O número está entre {menor} e {maior}.");
            }
            else
            {
                Console.WriteLine("Parabéns, você perdeu, Jogador 2!");
                acertou = true;
            }
        }
    }
}
