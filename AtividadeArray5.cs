// Atividade 5 — Maior número
// Crie um array para 5 números (digitado pelo usuário) e mostre qual é o maior valor digitado

public static class AtividadeArray5

{
    public static void Executar()
    {
        double[] numero = new double[5];
        double maior = 0;

        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"Digite o número {contador + 1}");
            numero[contador] = double.Parse(Console.ReadLine()!);

        }
        maior = numero[0];
        for (int verificar = 0; verificar < 5; verificar++)
        {
            //Pergunta se a proxima nota digitada é maior que a nota ja denominada maior.
            if (maior < numero[verificar + 1])
            {
                maior = numero[verificar + 1];
            }
        }


        Console.WriteLine($"O maior número é {maior}");

    }
}