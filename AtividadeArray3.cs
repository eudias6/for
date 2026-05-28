// Atividade 3 — Soma dos números
// Crie um array para 5 números inteiros (digitados pelo usuário) e calcule a soma de todos os valores.

public static class AtividadeArray3

{
    public static void Executar()
    {
        int[] numero = new int[5];

        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"Digite o número desejado {contador + 1}");
            numero[contador] = int.Parse(Console.ReadLine()!);
        }

        int soma = 0;

        for (int contador = 0; contador < 5; contador++)
        {
            soma = soma + numero[contador];

        }
        Console.WriteLine($"A soma dos números digitados pelo usuário é {soma}");


    }
}