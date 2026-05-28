// Atividade 6 — Maior valor
// Crie uma matriz 2x3 com números inteiros e mostre qual é o maior valor da matriz.

public static class AtividadeMatriz6

{
    public static void Executar()
    {
        int[,] tabela = new int[2, 3];
        int maior = 0;

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.WriteLine($"Digite o {linha * coluna + 1}º número");
                tabela[linha, coluna] = int.Parse(Console.ReadLine()!);
            }
        }

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (tabela[linha, coluna] > maior)
                {
                    maior = tabela[linha, coluna];
                }
            }
        }

        Console.WriteLine(maior);

    }
}