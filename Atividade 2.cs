using System;

class Program
{
    static void Main(string[] args)
    {
        string[] produtos = new string[10];
        double[] precos = new double[10];
        Console.WriteLine("Cadastro de Produtos:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do produto {i + 1}: ");
            produtos[i] = Console.ReadLine();
            Console.Write($"Digite o preço do produto {i + 1}: ");
            precos[i] = double.Parse(Console.ReadLine());
        }
        Console.Write("\nDigite um valor para pesquisar produtos com preço até esse valor: ");
        double valorLimite = double.Parse(Console.ReadLine());
        Console.WriteLine("\nProdutos com preço até o valor digitado:");
        for (int i = 0; i < 10; i++)
        {
            if (precos[i] <= valorLimite)
            {
                Console.WriteLine($"Produto: {produtos[i]}, Preço: R$ {precos[i]:F2}");
            }
        }
    }
}
