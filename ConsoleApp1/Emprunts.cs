using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Emprunts
    {
        DateTime DateEmprunt;
        DateTime DateRetour;
        public Emprunts(DateTime dateEmprunt, DateTime dateRetour)
        {
            DateEmprunt = dateEmprunt;
            DateRetour = dateRetour;
        }

        public int CalculerDuree()
        {
            int TempsEmprunt = DateEmprunt - DateRetour;
        }
    }
}
