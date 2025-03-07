using System;

class Program
{
    static void Main()
    {
         
        Console.Write("Digite a quantidade de pessoas: ");
        int N = int.Parse(Console.ReadLine());

        double altura;
        string sexo;
        double menorAltura = double.MaxValue;
        double maiorAltura = double.MinValue;
        double somaAlturasMulheres = 0;
        int contadorMulheres = 0;
        int contadorHomens = 0;

         
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite a altura da pessoa {i + 1}: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write($"Digite o sexo da pessoa {i + 1} (M/F): ");
            sexo = Console.ReadLine().ToUpper();

             
            if (altura < menorAltura)
            {
                menorAltura = altura;
            }

            if (altura > maiorAltura)
            {
                maiorAltura = altura;
            }

            
            if (sexo == "F")
            {
                somaAlturasMulheres += altura;
                contadorMulheres++;
            }
            else if (sexo == "M")
            {
                contadorHomens++;
            }
        }

        
        double mediaAlturasMulheres = contadorMulheres > 0 ? somaAlturasMulheres / contadorMulheres : 0;

        
        Console.WriteLine($"Menor altura = {menorAltura:F2}");
        Console.WriteLine($"Maior altura = {maiorAltura:F2}");
        Console.WriteLine($"Média das alturas das mulheres = {mediaAlturasMulheres:F2}");
        Console.WriteLine($"Número de homens = {contadorHomens}");
    }
}