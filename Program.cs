// Faça um algoritmo que calcule e exiba o salário reajustado de 3 funcionários de acordo com a seguinte regra: 
// Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salário de 3 funcionários da sua empresa para receberem os devidos reajustes.");
            Console.WriteLine("Salário do primeiro funcionário: ");
            double salario1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Salário do segundo funcionário: ");
            double salario2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Salário do terceiro funcionário: ");
            double salario3 = Convert.ToDouble(Console.ReadLine());

            double salario4, salario5, salario6;

            if (salario1 <= 300)
            {
                salario4 = 1.5 * salario1;
                Console.WriteLine("O salário do primeiro funcionario reajustado é: " + salario4);
            }
            else
            {
                salario4 = 1.3 * salario1;
                Console.WriteLine("O salário do primeiro funcionario reajustado é: " + salario4);
            }
            if (salario2 <= 300)
            {
                salario5 = 1.5 * salario2;
                Console.WriteLine("O salário do segundo funcionario reajustado é: " + salario5);
            }
            else
            {
                salario5 = 1.3 * salario2;
                Console.WriteLine("O salário do segundo funcionario reajustado é: " + salario5);
            }
            if (salario3 <= 300)
            {
                salario6 = 1.5 * salario3;
                Console.WriteLine("O salário do terceiro funcionario reajustado é: " + salario6);
            }
            else
            {
                salario6 = 1.3 * salario3;
                Console.WriteLine("O salário do terceiro funcionario reajustado é: " + salario6);
            }
        }
    }
}