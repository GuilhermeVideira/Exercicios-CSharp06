using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Digite o número para guardar em A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número para guardar em B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A = {0} e B = {1}", A, B);
            Console.WriteLine("\n\nInvertendo os valores de A e B");
            C = A;
            A = B;
            B = C;
            Console.WriteLine("A = {0} e B = {1}", A, B);
            Console.ReadKey();

        }
    }
}
