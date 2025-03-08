using System;

class Program
{
    static void Main(string[] args)
    {
        string[] alunos = new string[10];
        double[,] notas = new double[10, 3];
        double[] medias = new double[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            alunos[i] = Console.ReadLine();

            Console.WriteLine($"Digite as 3 notas do aluno {alunos[i]}:");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Nota {j + 1}: ");
                notas[i, j] = double.Parse(Console.ReadLine());
            }
            medias[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3.0;
        }
        Console.WriteLine("\nRELATÓRIO FINAL:");
        for (int i = 0; i < 10; i++)
        {
            if (medias[i] >= 7.0)
                Console.ForegroundColor = ConsoleColor.Blue; 
            else
                Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine($"Aluno: {alunos[i]}");
            Console.WriteLine($"Notas: {notas[i, 0]}, {notas[i, 1]}, {notas[i, 2]}");
            Console.WriteLine($"Média: {medias[i]:F2}");
            Console.WriteLine(medias[i] >= 7.0 ? "Situação: APROVADO" : "Situação: REPROVADO");
            Console.WriteLine(new string('-', 30)); 
        }
        Console.ResetColor();
    }
}
