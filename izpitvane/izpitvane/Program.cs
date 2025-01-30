using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kolko 4isla 6te vuvejda6");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("vuvedi 4islo");
                b[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("izhod1");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + "-");
            }
            Console.WriteLine();
            Console.WriteLine("izhod2");
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 != 1)
                {
                    Console.WriteLine(b[i]);
                }
            }
            Console.WriteLine("izhod3");

            for (int i = b.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(b[i]);
            }
            Console.WriteLine("izhod 4");
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] > 10 && b[i] <= 20)
                {
                    Console.WriteLine(b[i]);
                }
            }
            Console.WriteLine("izhod 5");
            int sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
            }
            Console.WriteLine(sum);
        }
    }
}
