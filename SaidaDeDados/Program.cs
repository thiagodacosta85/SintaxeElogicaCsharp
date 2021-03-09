using System;
using System.Globalization;

namespace saidadedados
{
    class Program
    {
        static void Main(string[] args)
        {
            //atribuindo uma variavel para a expressao CI (economizando tempo)
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            int x, y;
            x = 10;
            y = 20;

            double z;

            z = 3.141592;

            System.Console.Write("Bom dia.");
            System.Console.Write("Boa tarde.");
            System.Console.Write("Boa noite.");
            
            System.Console.WriteLine("Bom dia.");
            System.Console.WriteLine("Boa tarde.");
            System.Console.WriteLine("Boa noite.");

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);

            //opcao 1 - escrevendo a expressao toda na linha
            //System.Console.WriteLine(z.ToString("F3" , CultureInfo.InvariantCulture));

            System.Console.WriteLine(z.ToString("F3" , CI));

        }
    }
}
