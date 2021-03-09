using System;
using System.Globalization;

namespace saidaconcatenada
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 35;
            double salario = 5000.0;
            string nome = "Thiago";
            char sexo = 'M';

            CultureInfo CI = CultureInfo.InvariantCulture;

            System.Console.WriteLine("O funcionário " + nome + ", tem " + idade + 
            " anos, é do sexo: " + sexo + ", e recebe o salário de: R$ " + salario.ToString("F2", CI));
        }
    }
}
