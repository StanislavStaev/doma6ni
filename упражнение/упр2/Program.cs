using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace упр2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi duma s malki bukvi");
            string duma = Console.ReadLine();
            for (int i = 0; i < duma.Length; i++)
            {
                int n = (int)duma[i] - (int)'a';
                Console.WriteLine($"bukva {duma[i]} e na {n}");
            }
        }
    }
}
