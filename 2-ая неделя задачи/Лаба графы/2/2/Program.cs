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
            Console.WriteLine("Введите два числа n и m через пробел");
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            int n = int.Parse(a[0]);
            int m = int.Parse(a[1]);
            int[,] ma = new int[n, n + 1];
            Console.WriteLine("Введите два числа u и v через пробел");

            for (int i = 0; i < m; i++)
            {
                s = Console.ReadLine();
                string[] a2 = s.Split(' ');
                int x = int.Parse(a2[0]);
                int y = int.Parse(a2[1]);
                ma[x - 1, y - 1] = 1;
                ma[y - 1, x - 1] = 1;                                                                                           
            }

            for (int i = 0; i < n; i++)
            {
                int k = 0;
                for (int j = 0; j < n; j++)
                {
                    k += ma[i, j];
                }
                ma[i, n] = k;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(ma[i, n] + ": ");
                for (int j = 0; j < n; j++)
                {
                    if (ma[i, j] == 1)
                        Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

