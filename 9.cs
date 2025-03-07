using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Digite a quantidade de mercadorias: ");
        int N = int.Parse(Console.ReadLine());

        string[] nomes = new string[N];
        double[] precoCompra = new double[N];
        double[] precoVenda = new double[N];

        
        int menosDe10 = 0, entre10e20 = 0, maisDe20 = 0;
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

       
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o nome da mercadoria {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Digite o preço de compra da mercadoria {nomes[i]}: ");
            precoCompra[i] = double.Parse(Console.ReadLine());

            Console.Write($"Digite o preço de venda da mercadoria {nomes[i]}: ");
            precoVenda[i] = double.Parse(Console.ReadLine());

            
            double lucro = precoVenda[i] - precoCompra[i];
            double percentualLucro = (lucro / precoCompra[i]) * 100;

           
            if (percentualLucro < 10)
            {
                menosDe10++;
            }
            else if (percentualLucro >= 10 && percentualLucro <= 20)
            {
                entre10e20++;
            }
            else
            {
                maisDe20++;
            }

           
            totalCompra += precoCompra[i];
            totalVenda += precoVenda[i];
            lucroTotal += lucro;
        }

        
        Console.WriteLine($"Quantidade de mercadorias com lucro < 10%: {menosDe10}");
        Console.WriteLine($"Quantidade de mercadorias com lucro entre 10% e 20%: {entre10e20}");
        Console.WriteLine($"Quantidade de mercadorias com lucro > 20%: {maisDe20}");
        Console.WriteLine($"Valor total de compra: {totalCompra:F2}");
        Console.WriteLine($"Valor total de venda: {totalVenda:F2}");
        Console.WriteLine($"Lucro total: {lucroTotal:F2}");
    }
}