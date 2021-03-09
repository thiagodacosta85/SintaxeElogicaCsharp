using System;

namespace estruturafor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, x, soma;

            System.Console.Write("Quantos números serão digitados: ");
            N = int.Parse(Console.ReadLine());

            soma = 0;

            for (i = 1; i <= N; i++)
            {
                System.Console.Write("Digite um número: ");
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            System.Console.WriteLine("Soma: " + soma);
        }
    }
}
