using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, Z, W;
            string sim = "verdadeiro", nao = "falso";
            Console.WriteLine("Digite o valor de X: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y: ");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Z: ");
            Z = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de W: ");
            W = int.Parse(Console.ReadLine());
            Console.WriteLine(((X >= Y) && (Z <= X)) || ((X == W) && (Y == Z)) || (!(X != W)) ? sim : nao);

        }
    }
}
