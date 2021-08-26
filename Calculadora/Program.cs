using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            string operacao;
            while (n == 1)
            {
                Console.WriteLine("Seja bem vindo, qual operação deseja usar?");
                Console.WriteLine("a. Adição s.Subtração m.Multiplicação d.Divisão");
                operacao = Console.ReadLine();

                if (operacao == "a")
                {
                    Console.WriteLine("Digite os valores da soma");
                    Console.Write("Primeiro valor:");
                    double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Segundo valor:");
                    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("O resultado é: " + Calculadora.Soma(valor1, valor2));
                }
                else if (operacao == "s")
                {
                    Console.WriteLine("Digite os valores da subtração");
                    Console.Write("Primeiro valor:");
                    double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Segundo valor:");
                    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("O resultado é: " + Calculadora.Subtracao(valor1, valor2));
                }
                else if (operacao == "m")
                {
                    Console.WriteLine("Digite os valores da multiplicação");
                    Console.Write("Primeiro valor:");
                    double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Segundo valor:");
                    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("O resultado é: " + Calculadora.Multiplicacao(valor1, valor2));
                }
                else if (operacao == "d")
                {
                    Console.WriteLine("Digite os valores da divisão");
                    Console.Write("Primeiro valor:");
                    double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Segundo valor:");
                    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("O resultado é: " + Calculadora.Divisao(valor1, valor2));
                };

                Console.WriteLine();
                Console.WriteLine("Deseja fazer uma nova operação?");
                Console.WriteLine("1. Sim 2.Não");
                int b = int.Parse(Console.ReadLine());
                n = b;
                Console.WriteLine("-------------------------------------------------------------------");

            }


        }
    }
}
