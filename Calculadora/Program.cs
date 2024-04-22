using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escolher a operação.
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação\n");

            decimal operacao = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = Multp(num1, num2);
                        break;
                    }
                default:
                        Console.WriteLine("Digite um valor correto!");
                        break;
                    
            }
            Console.WriteLine("O resultado de {0} e {1} é de: {2}", num1, num2, resultado);
            Console.ReadKey();
        }

        
        
        
        // Metodos da operação.
        public static decimal Adicao(decimal num1, decimal num2)
        {
            decimal resultado = num1 + num2;
            return resultado;
        }

        public static decimal Subtracao(decimal num1, decimal num2)
        {
            decimal resultado = num1 - num2;
            return resultado;
        }

        public static decimal Divisao(decimal num1, decimal num2)
        {
            decimal resultado = num1 / num2;
            return resultado;
        }

        public static decimal Multp(decimal num1, decimal num2)
        {
            decimal resultado = num1 * num2;
            return resultado;
        }

    }


}




