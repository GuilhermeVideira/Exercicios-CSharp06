using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um numero:");
            num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O dobro do numero {0} é {1}", num, (num * 2));
            Console.ReadKey();

        }
    }
}
