using System;
using System.Globalization;

namespace processecast
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            /*
            aqui neste caso sem combinar tipos de dados.
            int x, y;
            x = 10;
            y = 20;
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            */

            int x;
            double y;

            x = 5;
            y = 2 * x;

            System.Console.WriteLine(x);
            System.Console.WriteLine(y.ToString("F2", CI));

            //casting
            int a, b;

            double resultado;

            a = 5;
            b = 2;

            //aplicando um casting para converter ao menos uma varíavel para double.
            resultado = ((double)a) / b;
            System.Console.WriteLine(resultado);

            double z;
            int w;

            z = 5.2;
            w = (int)z;

            System.Console.WriteLine(w);



        }
    }
}
