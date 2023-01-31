using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            Console.Write("Insira o nome da primeira pessoa: ");
            nome1 = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Insira o nome da segunda pessoa: ");
            nome2 = (Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Os nomes em maiúculos das duas pessoas são: " + nome1.ToUpper() + " e " + nome2.ToUpper());
            Console.WriteLine();
            Console.WriteLine("O nome " + nome1 + " tem " + nome1.Length + " caracteres e o nome " + nome2 + " tem " + nome2.Length + " caracteres");
            Console.WriteLine();
            Console.WriteLine("Os três primeiros caracteres do nome " + nome1 + " são: " + nome1.ToUpper().Substring(0, 3) + " e do nome " + nome2 + " são: " + nome2.ToUpper().Substring(0, 3));
            Console.ReadKey();

        }
    }
}
