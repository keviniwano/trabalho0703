using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Digite a quantidade de números: ");
        int N = int.Parse(Console.ReadLine());

        double[] numeros = new double[N];
        double soma = 0;

        
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = double.Parse(Console.ReadLine());
            soma += numeros[i];
        }

        
        double media = soma / N;

        
        Console.WriteLine($"Média: {media:F3}");

         
        Console.WriteLine("Números abaixo da média:");
        foreach (double numero in numeros)
        {
            if (numero < media)
            {
                Console.WriteLine(numero);
            }
        }
    }
}