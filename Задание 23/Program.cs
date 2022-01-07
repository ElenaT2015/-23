using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задание_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int n = Convert.ToInt32(Console.ReadLine());
            SumAsync(n);

            Console.ReadKey();
        }
        static void Sum (int n)
        {
            Console.WriteLine("метод для вычисления факториала числа");
            int result = 1;
            for (int i = 1; i < n; i++)
            {
                result *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine($"Факториал равен {result}");
        }
        // определение асинхронного метода
        static async void SumAsync(int n)
        {
            await Task.Run(() => Sum(n)); // вызов асинхронной операции
        }
    }
}
