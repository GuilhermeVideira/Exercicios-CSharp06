using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double result;
            Console.WriteLine("\n Sistema para Claculo da Expressão A² * 5 – C / (B – A % 4)\n");
            Console.Write("\n Entre com os Valores abaixo");
            Console.Write("\n A = ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("\n B = ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("\n C = ");
            c = Double.Parse(Console.ReadLine());
            result = Math.Pow(a, 2) * 5 - c / (b - a % 4);
            Console.WriteLine("\n ####### Resultado da Expressão #######\n");
            Console.WriteLine("\n O valor da obtido da expressão é " + result);
            Console.ReadKey();

        }
    }
}
