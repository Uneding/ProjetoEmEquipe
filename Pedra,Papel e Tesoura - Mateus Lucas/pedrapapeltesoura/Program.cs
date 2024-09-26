﻿using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] opcoes = { "pedra", "papel", "tesoura" };

        while (true)
        {
            Console.WriteLine("Escolha: pedra, papel ou tesoura (ou 'sair' para encerrar): ");
            string usuario = Console.ReadLine().ToLower();

            if (usuario == "sair")
            {
                Console.WriteLine("Jogo encerrado.");
                break;
            }

            if (Array.IndexOf(opcoes, usuario) == -1)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            string computador = opcoes[random.Next(opcoes.Length)];
            Console.WriteLine($"Você escolheu: {usuario}");
            Console.WriteLine($"O computador escolheu: {computador}");

            if (usuario == computador)
            {
                Console.WriteLine("Empate!");
            }
            else if ((usuario == "pedra" && computador == "tesoura") ||
                     (usuario == "papel" && computador == "pedra") ||
                     (usuario == "tesoura" && computador == "papel"))
            {
                Console.WriteLine("Você venceu!");
            }
            else
            {
                Console.WriteLine("O computador venceu!");
            }
        }
    }
}