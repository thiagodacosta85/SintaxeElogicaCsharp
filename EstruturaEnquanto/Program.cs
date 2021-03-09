using System;

namespace estruturaenquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma, x;

            soma = 0;

            System.Console.WriteLine("Este programa encerrará quando o valor de entrada for Zero.");
            System.Console.Write("Digite o primeiro número: ");
            x = int.Parse(Console.ReadLine());

            while( x != 0)
            {
                soma = soma + x;
                System.Console.Write("Digite outro número: ");
                x = int.Parse(Console.ReadLine());
            }
            
            System.Console.WriteLine("Soma: " + soma);
        }
    }
}
