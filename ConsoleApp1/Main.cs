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
            Membres Jack = new Membres("Huber", "Jack", new DateTime(25, 2, 2006));
            Membres Emeline = new Membres("Hugues", "Emeline", new DateTime(02, 7, 1989));
            Membres Chaise = new Membres("Table", "Chaise", new DateTime(18,10,1998));

            Livres ChatBotté = new Livres(1628, "Charles Perrault","978-987-25620-2-1", "Chat Botté");
            Livres CyranoDeBergerac = new Livres(1628, "Edmond Rostand", "956-974-245731-3-2", "Cyrano De Bergerac");
            Livres FrigielEtFluffy = new Livres(1628, "Frigiel", "963-945-23569-4-1", "Frigiel et Fluffy");

            Emprunt emprunt = new Emprunt(Jack, ChatBotté, new DateTime(2023, 11, 1));

            Console.WriteLine($"Durée d'emprunt : {emprunt.CalculerDuree().Days} jours");

            // Simuler le retour du livre après quelques jours
            emprunt.DateRetour = new DateTime(2023, 11, 4);

            // Recalculer la durée après le retour du livre
            Console.WriteLine($"Durée d'emprunt après retour : {emprunt.CalculerDuree().Days} jours");
        }

    }
}
