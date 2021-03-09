using System;

namespace estruturacondicionalsimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;

            System.Console.Write("Informe uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                System.Console.WriteLine("Manhã");
            } else if (hora >= 12 & hora < 18 )
            {
                System.Console.WriteLine("Tarde");
            } else
            {
                System.Console.WriteLine("Noite.");
            }


        }
    }
}
