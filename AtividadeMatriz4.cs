// Atividade 4 — Média geral
// Crie uma matriz 3x2 de notas e calcule a média geral de todas as notas. Encontre uma forma que o divisor (do cálculo da média) 
//seja uma variável incrementada (não atribuir um valor fixo)

public static class AtividadeMatriz4

{
    public static void Executar()
    {
        int[,] notas = new int[3, 2];
        int soma = 0;
        int media = 0;
        int divisor = 0;

        for (int coluna = 0; coluna < 2; coluna++)
        {
            for (int linha = 0; linha < 3; linha++)
            {
                Console.WriteLine($"Digite a nota");
                notas[linha, coluna] = int.Parse(Console.ReadLine()!);
                soma += notas[linha, coluna];
                divisor++;

            }

        }
        media = soma / divisor;
        Console.WriteLine($"A média das notas é: {media}");


    }
}