using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite um número:");
            a = int.Parse(Console.ReadLine());
            if (a > 20 & a < 100)
            {
                Console.WriteLine("O número lido está entre 20 e 100.");
            }
            else
            {
                Console.WriteLine("O número lido não está entre 20 e 100.");
            }
            Console.ReadKey();
        }
    }
}
