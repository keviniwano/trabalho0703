using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Digite a quantidade de elementos: ");
        int N = int.Parse(Console.ReadLine());

        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];

        
        Console.WriteLine("Digite os elementos do vetor A:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            A[i] = int.Parse(Console.ReadLine());
        }

         
        Console.WriteLine("Digite os elementos do vetor B:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            B[i] = int.Parse(Console.ReadLine());
        }

         
        for (int i = 0; i < N; i++)
        {
            C[i] = A[i] + B[i];
        }

       
        Console.WriteLine("Vetor C (soma dos elementos):");
        Console.WriteLine(string.Join(" ", C));
    }
}