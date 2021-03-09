using System;
using System.Globalization;

namespace areadotrapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double b1, b2, h, area;

            System.Console.WriteLine("Calculando a área de um trapézio:");
            
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;

            /*
            System.Console.Write("Informe b1: ");
            System.Console.ReadLine(b1);
            System.Console.Write("Informe b2: ");
            System.Console.ReadLine(b2);
            System.Console.Write("Informe h: ");
            System.Console.ReadLine(h);
            */

            area = (b1+b2) / 2.0 * h;
            System.Console.WriteLine(area.ToString("F2", CI));

        }
    }
}
