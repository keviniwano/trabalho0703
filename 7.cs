using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Digite a quantidade de alunos: ");
        int N = int.Parse(Console.ReadLine());

        string[] nomes = new string[N];
        double[,] notas = new double[N, 2];

         
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Digite a nota do 1º semestre de {nomes[i]}: ");
            notas[i, 0] = double.Parse(Console.ReadLine());

            Console.Write($"Digite a nota do 2º semestre de {nomes[i]}: ");
            notas[i, 1] = double.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("Alunos aprovados:");
        for (int i = 0; i < N; i++)
        {
            double media = (notas[i, 0] + notas[i, 1]) / 2;
            if (media >= 6)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}