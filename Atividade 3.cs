using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3, 5];
        Console.WriteLine("Digite os 15 números para preencher a matriz (3x5):");
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 5; j++) 
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nSoma dos valores de cada linha:");
        for (int i = 0; i < 3; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < 5; j++)
            {
                somaLinha += matriz[i, j];
            }
            Console.WriteLine($"Linha {i}: {somaLinha}");
        }
    }
}
