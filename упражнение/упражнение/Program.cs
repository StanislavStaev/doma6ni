using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace упражнение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4isla");
            string chisla = Console.ReadLine();
            int[] numbers = chisla.Split(' ').Select(int.Parse).ToArray();
            int minElement = numbers.Min();
            int maxElement = numbers.Max();
            int sum = numbers.Sum();
            double a = numbers.Average();

            Console.WriteLine("naj malkiqt " +minElement);
            Console.WriteLine("naj golemiqt "+maxElement);
            Console.WriteLine("sumata e "+sum);
            Console.WriteLine("srednata stojnast e "+a);
        }
    }
}
