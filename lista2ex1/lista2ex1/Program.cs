using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("Digite o 1º valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine("Primeiro");
            else
                Console.WriteLine("Segundo");
        }
    }
}
