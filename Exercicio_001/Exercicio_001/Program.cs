using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, id, cid;
            Console.WriteLine("Digite o seu nome:");
            nom = Console.ReadLine();
            Console.WriteLine("Digite o nome da sua cidade:");
            cid = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            id = Console.ReadLine();
            Console.WriteLine("O seu nome é: {0},\n sua idade é: {1} anos e \n mora em : {2}", nom, id, cid);
            Console.ReadKey();

        }
    }
}
