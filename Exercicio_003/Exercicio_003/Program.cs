using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 3 - calcular quadrado de um número 
            int numero;
            double quadrado;
            Console.Write("entre com um número inteiro: ");
            numero = int.Parse(Console.ReadLine());
            quadrado = Math.Pow(numero, 2);
            Console.WriteLine("O quadrado de {0} é {1}", numero, quadrado);
            Console.ReadKey();

        }
    }
}
