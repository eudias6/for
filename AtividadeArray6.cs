// Atividade 6 — Ordenar
// Crie um array para 5 números (digitado pelo usuário) e ordene os números no array, 
// na sequencia apresente os números ordenados, utilizar somente recursos explicados em aula.

public static class AtividadeArray6

{
    public static void Executar()
    {
        int[] numeroDigitado = new int[5];
        int auxiliar = 0;

        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"Digite o número {contador + 1}");
            numeroDigitado[contador] = int.Parse(Console.ReadLine()!);

        }

        for (int verificar = 0; verificar < 5; verificar++)
        {
            for (int organizar = 0; organizar < 4; organizar++)
            {
                if (numeroDigitado[organizar] > numeroDigitado[organizar + 1])
                {
                    auxiliar = numeroDigitado[organizar + 1];
                    numeroDigitado[organizar + 1] = numeroDigitado[organizar];
                    numeroDigitado[organizar] = auxiliar;
                }
            }
        }


        for (int listar = 0; listar < 5; listar++)
        {
            Console.Write($"{numeroDigitado[listar]}   ");
        }

    }
}