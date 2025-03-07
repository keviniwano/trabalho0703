using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite a quantidade de números: ");
        int N = int.Parse(Console.ReadLine());

        double[] numeros = new double[N];

         
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

         
        double maiorNumero = numeros[0];
        int posicaoMaior = 0;

        for (int i = 1; i < N; i++)
        {
            if (numeros[i] > maiorNumero)
            {
                maiorNumero = numeros[i];
                posicaoMaior = i;
            }
        }

         
        Console.WriteLine($"O maior número é: {maiorNumero}");
        Console.WriteLine($"A posição do maior número é: {posicaoMaior}");
    }
}