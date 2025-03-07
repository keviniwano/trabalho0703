using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite a quantidade de números: ");
        int N = int.Parse(Console.ReadLine());

        int[] numeros = new int[N];

         
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

         
        List<int> numerosPares = new List<int>();

         
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                numerosPares.Add(numero);
            }
        }

          
        Console.WriteLine("Números pares: " + string.Join(" ", numerosPares));
        Console.WriteLine("Quantidade de números pares: " + numerosPares.Count);
    }
}