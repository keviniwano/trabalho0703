using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite a quantidade de pessoas: ");
        int N = int.Parse(Console.ReadLine());

        string nomeMaisVelho = "";
        int idadeMaisVelha = 0;

        for (int i = 0; i < N; i++)
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            
            if (idade > idadeMaisVelha)
            {
                idadeMaisVelha = idade;
                nomeMaisVelho = nome;
            }
        }

       
        Console.WriteLine($"Pessoa mais velha: {nomeMaisVelho}");
    }
}