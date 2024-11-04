using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Membres Jack = new Membres("Huber", "Jack", "02-02-1998" );
            Membres Emeline = new Membres("Hugues", "Emeline", "12-12-2005" );
            Membres Chaise = new Membres("Table", "Chaise", "29-05-1985" );

            Livres ChatBotté = new Livres(1628, "Charles Perrault","978-987-25620-2-1", "Chat Botté");
            Livres CyranoDeBergerac = new Livres(1628, "Edmond Rostand", "956-974-245731-3-2", "Cyrano De Bergerac");
            Livres FrigielEtFluffy = new Livres(1628, "Frigiel", "963-945-23569-4-1", "Frigiel et Fluffy");
        }

    }
}
