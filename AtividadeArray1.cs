// Atividade 1 — Lista de nomes
// Crie um array para 5 nomes de alunos (digitados pelo usuário) e exiba todos usando
// for


public static class AtividadeArray1

{
    public static void Executar()
    {
        string[] nomesAlunos = new string[5];

        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"Digite o nome do {contador + 1}ºaluno");
            nomesAlunos[contador] = Console.ReadLine()!;
        }

        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"O nome do {contador + 1}ºaluno é {nomesAlunos[contador]}");
        }

    }


}