using System;
using System.Linq;

namespace Prakt17Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите кол-во элементов массива:");
            try
            {
                int N = Convert.ToInt32(Console.ReadLine());
                if (N <= 0) { Console.WriteLine("Кол-во элементов не может быть меньше 0!"); }
                else
                {
                    double[] mas = new double[N];

                    for (int i = 0; i < mas.Length; i++)
                    {
                        mas[i] = rnd.Next(5, 10) * 0.01;
                        Console.Write(mas[i] + " ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("---А---");

                    foreach (var item in mas.GroupBy(x => x).Where(x => x.Count() > 0).Select(x => new { elements = x.Key, count = x.Count() }))
                    {
                        Console.WriteLine(item.elements + " - " + item.count);
                    }

                    Console.WriteLine("---Б---");

                    double ch = 0;
                    foreach (var item in mas.GroupBy(x => x).Where(x => x.Count() > 0).Select(x => new { elements = x.Key, count = x.Count() }))
                    {
                        ch = item.count;
                        var s = item.elements * ch;
                        Console.WriteLine(s + " - " + item.count);
                    }
                }
            }
            catch { Console.WriteLine("Неправильный тип данных!"); }
        }
    }
}
