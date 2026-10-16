using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_7
{
    public class VController
    {
        private Vakancia vakancia;
        private Display display;
        public VController()
        {
            vakancia = new Vakancia();
            display = new Display();

            vakancia.Budget = display.ReadBudget();
           vakancia.Seson = display.ReadSeson();
            vakancia.CalculateVacation();
            display.ShowResult(vakancia.Destinacia, vakancia.Nastanqvane,vakancia.Price);
        }
    }
}
