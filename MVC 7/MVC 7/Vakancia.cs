using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_7
{
    public class Vakancia
    {
        public double Budget { get; set; }
        public string Seson { get;set; }
        public string Destinacia { get; set; }
        public string Nastanqvane { get;set; }
        public double Cena { get;  set; }
        public void CalculateVacation()
        {
            if (Budget <= 100)
            {
                Destinacia = "Bulgaria";
                if (Seson == "sumer")
                {
                    Nastanqvane = "Camp";
                    Cena = Budget * 0.30;
                }
                else
                { Nastanqvane = "Hotel";
                   Cena = Budget * 0.70;
                }
            }


            else if (Budget <= 1000)
            {
                Destinacia = "Balkans";
                if (Seson == "summer")
                {
                   Nastanqvane = "camp";
                    Cena = Budget * 0.40;
                }
                else {             
                    Nastanqvane = "Hotel";
                  Cena = Budget * 0.80;
                }
            }
            else
            {
                Destinacia = "Europe";
               Nastanqvane = "Hotel";
                 Cena = Budget * 0.90;
            }
        }
    }
}
