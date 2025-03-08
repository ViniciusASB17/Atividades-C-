using System;

class Program
{
    static void Main(string[] args)
    {
        char[,] tabuleiro = new char[3, 3];
        InicializarTabuleiro(tabuleiro);
        int jogadas = 0;
        bool jogoTerminado = false;
        while (!jogoTerminado && jogadas < 9)
        {
            ExibirTabuleiro(tabuleiro);
            char jogadorAtual = (jogadas % 2 == 0) ? 'X' : 'O';
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"\nVez do jogador {jogadorAtual}");
            int linha, coluna;
            do
            {
                Console.WriteLine("-------------------------");
                Console.Write("Digite a linha (0, 1 ou 2): ");
                linha = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------");
                Console.Write("Digite a coluna (0, 1 ou 2): ");
                coluna = int.Parse(Console.ReadLine());
            } while (!PosicaoValida(tabuleiro, linha, coluna));

            tabuleiro[linha, coluna] = jogadorAtual;
            jogadas++;
            if (VerificarVitoria(tabuleiro, jogadorAtual))
            {
                ExibirTabuleiro(tabuleiro);
                Console.WriteLine("-------------------Parabéns venceu!!---------------------");
                Console.WriteLine($"\nJogador {jogadorAtual}");
                jogoTerminado = true;
            }
        }
        if (!jogoTerminado)
        {
            ExibirTabuleiro(tabuleiro);
            Console.WriteLine("-------------:/--------------");
            Console.WriteLine("\nO jogo terminou em empate!");
        }
    }
    static void InicializarTabuleiro(char[,] tabuleiro)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }
    }
    static void ExibirTabuleiro(char[,] tabuleiro)
    {
        Console.WriteLine("\nTabuleiro:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {tabuleiro[i, j]} ");
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("---+---+---");
        }
    }
    static bool PosicaoValida(char[,] tabuleiro, int linha, int coluna)
    {
        if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Posição inválida! Tente novamente.");
            return false;
        }
        if (tabuleiro[linha, coluna] != ' ')
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Posição já ocupada! Tente novamente.");
            return false;
        }
        return true;
    }
    static bool VerificarVitoria(char[,] tabuleiro, char jogador)
    {
       
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador)
                return true;
        }

        for (int j = 0; j < 3; j++)
        {
            if (tabuleiro[0, j] == jogador && tabuleiro[1, j] == jogador && tabuleiro[2, j] == jogador)
                return true;
        }

        if (tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador)
            return true;

        if (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador)
            return true;

        return false;
    }
}
