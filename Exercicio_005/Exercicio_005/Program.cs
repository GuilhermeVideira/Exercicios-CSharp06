using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Entre com a idade da pessoa: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Essa pessoa é {0}", idade >= 18 ? "maior de idade." : "menor de idade.");
            Console.ReadKey();

        }
    }
}
