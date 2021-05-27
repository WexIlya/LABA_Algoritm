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


            Console.WriteLine("Введите размер матрицы");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите матрицу");
            int[,] m = new int[n, n + 1];
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                string s = Console.ReadLine();
                string[] a = s.Split(' ');
                for (int j = 0; j < n; j++)
                {

                    m[i, j] = int.Parse(a[j]);
                    k += m[i, j];
                }
                m[i, n] = k;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(m[i, n] + ": ");
                for (int j = 0; j < n; j++)
                {
                    if (m[i, j] != 0)
                        Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

