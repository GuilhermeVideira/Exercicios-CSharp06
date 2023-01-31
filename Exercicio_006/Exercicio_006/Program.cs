using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double reais, cotacao, dolares;
            Console.Write("Digite a quantidade de reais: ");
            reais = double.Parse(Console.ReadLine());
            Console.Write("Digite a cotação do dólar: ");
            cotacao = double.Parse(Console.ReadLine());
            dolares = reais / cotacao;
            Console.WriteLine("{0:N2} reais equivalem a {1:N2} dolares", reais, dolares);
            Console.ReadKey();

        }
    }
}
