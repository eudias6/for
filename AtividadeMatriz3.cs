// Atividade 3 — Soma dos valores
// Crie uma matriz 2x2 com números inteiros e calcule a soma de todos os valores

public static class AtividadeMatriz3

{
    public static void Executar()
    {
        //int[,] numeros = new int[2, 2];
        int[,] numeros = new int[2, 2];



        Console.WriteLine("Digite o primeiro número:");
        numeros[0, 0] = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o primeiro número:");
        numeros[0, 1] = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o primeiro número:");
        numeros[1, 0] = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o primeiro número:");
        numeros[1, 1] = int.Parse(Console.ReadLine()!);


        // for (int linha = 0; linha < 2; linha++)

        // {
        //     for (int coluna = 0; coluna < 2; coluna++)
        //     {
        //         Console.WriteLine("Digite o primeiro número:");
        //         numeros[linha, coluna] = int.Parse(Console.ReadLine()!);
        //     }
        // }

        // for (int linha = 0; linha < 2; linha++)

        // {
        //     for (int coluna = 0; coluna < 2; coluna++)
        //     {
        //         Console.Write($"Linha {linha}, Coluna {coluna}: {numeros[linha, coluna]}");
        //     }
        // }

        int soma = 0;


        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                soma = soma + numeros[linha, coluna];
            }
        }
        Console.WriteLine($"A soma é {soma}");
    }
}