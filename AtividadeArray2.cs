// Atividade 2 — Lista de números
// Crie um array para 6 números inteiros (digitados pelo usuário) e exiba todos usando
// for
// .

public static class AtividadeArray2

{
    public static void Executar()
    {
        int[] numero = new int[6];

        for (int contador = 0; contador < 6; contador++)
        {
            Console.WriteLine($"Digite o número desejado {contador + 1}");
            numero[contador] = int.Parse(Console.ReadLine()!);
        }

        for (int contador = 0; contador < 6; contador++)
        {
            Console.WriteLine($"O número digitado pelo usuário {contador + 1} é {numero[contador]}");
        }

    }


}