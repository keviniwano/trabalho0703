using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
         
        Console.Write("Digite a quantidade de números: ");
        int N = int.Parse(Console.ReadLine());

        int[] numeros = new int[N];
        List<int> pares = new List<int>();

       
        Console.WriteLine("Digite os números:");
        for (int i = 0; i < N; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
           
            if (numeros[i] % 2 == 0)
            {
                pares.Add(numeros[i]);
            }
        }

       
        if (pares.Count > 0)
        {
            double media = pares.Average();
            Console.WriteLine($"Média dos números pares: {media:F1}");
        }
        else
        {
            Console.WriteLine("Nenhum número par foi digitado.");
        }
    }
}