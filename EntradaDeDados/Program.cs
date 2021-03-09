using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double salario1, salario2;
            string nome1, nome2;

            int idade;
            char sexo;

            System.Console.Write("Digite o nome da primeira pessoa: ");
            nome1 = System.Console.ReadLine();
            System.Console.Write("Digite o salário da primeira pessoa: ");
            salario1 = double.Parse(Console.ReadLine(), CI);

            System.Console.Write("Digite o nome da segunda pessoa: ");
            nome2 = System.Console.ReadLine();
            System.Console.Write("Digite o salário da segunda pessoa: ");
            salario2 = double.Parse(Console.ReadLine(), CI);

            System.Console.Write("Digite uma idade: ");
            idade = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o sexo(M/F): ");
            sexo = char.Parse(Console.ReadLine());

            System.Console.WriteLine("Nome 1 = " + nome1);
            System.Console.WriteLine("Salário 1: " + salario1.ToString("F2", CI));

            System.Console.WriteLine("Nome 2 = " + nome2);
        System.Console.WriteLine("Salário 2 = " + salario2.ToString("F2",CI));

        System.Console.WriteLine("Idade: " + idade);
        System.Console.WriteLine("Sexo: " + sexo);
        }
    }
}
