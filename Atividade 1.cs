using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[15];
        Console.WriteLine("Digite 15 números inteiros:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Posição {i}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nNúmeros armazenados nas posições pares:");
        for (int i = 0; i < numeros.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"Posição {i}: {numeros[i]}");
            }
        }
    }
}
