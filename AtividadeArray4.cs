// Atividade 4 — Média de notas
// Crie um array para 4 notas (digitado pelo usuário) e calcule a média final.

public static class AtividadeArray4

{
    public static void Executar()
    {
        double[] nota = new double[4];
        double media = 0;

        for (int contador = 0; contador < 4; contador++)
        {
            Console.WriteLine($"Digite a nota {contador + 1}");
            nota[contador] = double.Parse(Console.ReadLine()!);
            media += nota[contador];
        }


        Console.WriteLine($"A média final é {media / 4}");

    }
}