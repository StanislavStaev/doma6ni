using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_7
{
    public class Display
    {
        public double ReadBudget()
        {
            return double.Parse(Console.ReadLine());
        }
        public string ReadSeson()
        {
            return Console.ReadLine();
        }
        public void ShowResult(string destinacia, string nastanqvane, double cena)
        {
            Console.WriteLine("Nqkude v"+destinacia);
            Console.WriteLine($"{nastanqvane} - {cena:F2}");
        }
    }
}