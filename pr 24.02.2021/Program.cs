using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_24._02._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4, i, j, countminus = 0;
            double[,] A = new double[a, b];
            int[] count = new int[b];
            genereteMas(A, a, b, -100, 100);
            //writeMas(A, a, b);
            for (j = 0; j < b; j++)
                for (i = 0; i < a; i++)
                {
                    if (A[i, j] < 0)
                        countminus++;
                }
            printMas(A, a, b, "Масив");
            Console.WriteLine($"Кiлькiсть вiд'ємних елементив масиву = {countminus}");
            Console.ReadKey();
        }

        static void genereteMas(double[,] mas, int n, int m, double a, double b)//генерування масиву
        {
            Random random = new Random();
            int i, j;
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    mas[i, j] = a + random.NextDouble() * (b - a);
        }

        static void printMas(double[,] mas, int n, int m, string s)//друк масиву
        {
            Console.WriteLine(s);
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write("{0,5:N2}\t", mas[i, j]);
                Console.WriteLine();
            }
        }

        static void writeMas(double[,] mas, int n, int m)//метод для вводу масиву вручну
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                {
                    Console.Clear();
                    Console.Write("Введiть [" + (i + 1).ToString() + "," + (j + 1).ToString() + "] елемент: ");
                    mas[i, j] = Convert.ToDouble(Console.ReadLine());
                }
        }
    }
}
