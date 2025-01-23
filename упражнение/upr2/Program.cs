using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4islo ");
            string chisla = Console.ReadLine();
            int[] number = Array.ConvertAll(chisla.Split(' '), int.Parse);
            while (number.Length > 1)
            {
                int[] newnum = new int[number.Length - 1];
                for (int i = 0; i < number.Length - 1; i++)
                {
                    newnum[i] = number[i] + number[i + 1];
                }
                number = newnum;
            }
            Console.WriteLine($"rezultata e {number[0]}");
        }
    }
}
