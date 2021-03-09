using System;
using System.Globalization;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, i;

            System.Console.Write("Quantos números serão digitados: ");
            N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            for (i = 0; i < N; i++)
            {
                System.Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Números digitados: ");
            for(i = 0; i < N; i++)
            {
                System.Console.WriteLine(vet[i].ToString("F1", CI));
            } 
        }
    }
}