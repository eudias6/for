
// ## Atv4 - Tabuada

// Crie um programa que peça um número ao usuário e mostre a tabuada desse número de `1` até `10`. 
// (proíbido o uso de foreach ou qualquer outro tipo, é permitido somente o uso de for)

public static class Atividade4
{
    public static void Executar()
    {
        Console.Write("Digite um número para ver a tabuada: ");
        int numero = int.Parse(Console.ReadLine()!);

        for (int contador = 1; contador <= 10; contador++)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
        }
    }
}