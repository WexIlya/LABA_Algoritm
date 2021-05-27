using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите через пробел с какими вершинами связанна данная точка");
            string b = "";
            for (int i = 0; i < x; i++)
            {
                b = Console.ReadLine();
                string[] a = b.Split(':', ' ');
                for (int j = 1; j < a.Length; j++)
                {
                    Console.WriteLine("(" + a[0] + ", " + a[j] + ")");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
