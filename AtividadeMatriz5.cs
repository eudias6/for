// Atividade 5 — Média por aluno
// Crie uma matriz em que cada linha representa um aluno e cada coluna representa uma nota. Calcule a média de cada aluno.

public static class AtividadeMatriz5

{
    public static void Executar()
    {
        string[] nome = new string[3];

        for (int linha = 0; linha < 3; linha++)
        {
            Console.Write($"Digite o {linha + 1}º nome: ");
            nome[linha] = Console.ReadLine()!;
        }

        double[,] nota = new double[3, 2];
        double soma = 0;
        double media = 0;
        double divisor = 0;

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write($"Digite a {coluna + 1}º nota do(a) aluno {nome[linha]}:");
                nota[linha, coluna] = int.Parse(Console.ReadLine()!);
                soma += nota[linha, coluna];
                divisor++;

                if (coluna == 1)
                {
                    media = soma / divisor;
                    Console.WriteLine($"A média do aluno {nome[linha]} é {media}");
                    Console.WriteLine();
                }
            }
            soma = 0;
            media = 0;
            divisor = 0;
        }

    }
}