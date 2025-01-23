using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace упр1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4isla razdeleni s interval  ");
            string chisla = Console.ReadLine();
            int[] numbers = Array.ConvertAll(chisla.Split(' '), int.Parse);
            Array.Sort(numbers);
            int maxFrequency = 1;
            int currentFrequency = 1;
            int mostFrequentNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentFrequency++;
                }
                else
                {
                    currentFrequency = 1;
                }
                if (currentFrequency > maxFrequency)
                {
                    maxFrequency = currentFrequency;
                    mostFrequentNumber = numbers[i];
                }
            }
            Console.WriteLine("naj 4esto sre6tanoto e " +mostFrequentNumber);
            Console.WriteLine($"sre6ta se  {maxFrequency} puti" );
        }
    }
}
