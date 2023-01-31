using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_008
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double vl;
            double cotd;
            double cote;
            double dol;
            double euro;
            Console.Write("Digite o valor em R$: ");
            vl = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da cotacaoDolar: ");
            cotd = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da cotacao Euro: ");
            cote = double.Parse(Console.ReadLine());
            dol = vl / cotd;
            euro = vl / cote;
            Console.WriteLine();
            Console.Write("O valor em dolár = $" + dol + "\nO valor em euro = $" + euro);
            Console.ReadKey();

        }
    }
}
