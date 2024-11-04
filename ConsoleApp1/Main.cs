using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Création des membres
            Membres Jack = new Membres("Huber", "Jack", new DateTime(2006, 2, 25));
            Membres Emeline = new Membres("Hugues", "Emeline", new DateTime(1989, 7, 2));
            Membres Chaise = new Membres("Table", "Chaise", new DateTime(1998, 10, 18));

            // Création des livres
            Livres ChatBotté = new Livres(1628, "Charles Perrault", "978-987-25620-2-1", "Chat Botté");
            Livres CyranoDeBergerac = new Livres(1628, "Edmond Rostand", "956-974-245731-3-2", "Cyrano De Bergerac");
            Livres FrigielEtFluffy = new Livres(1628, "Frigiel", "963-945-23569-4-1", "Frigiel et Fluffy");

            // Création de la bibliothèque
            Bibliotheque maBibliotheque = new Bibliotheque("Bibliothèque Municipale", "123 Rue des Livres");

            // Ajout de livres à la bibliothèque
            maBibliotheque.AjouterLivre(ChatBotté.Titre, ChatBotté.Auteur, ChatBotté.ISBN, ChatBotté.AnneePublication);
            maBibliotheque.AjouterLivre(CyranoDeBergerac.Titre, CyranoDeBergerac.Auteur, CyranoDeBergerac.ISBN, CyranoDeBergerac.AnneePublication);
            maBibliotheque.AjouterLivre(FrigielEtFluffy.Titre, FrigielEtFluffy.Auteur, FrigielEtFluffy.ISBN, FrigielEtFluffy.AnneePublication);

            // Emprunt de Chat Botté par Jack
            Emprunt emprunt = new Emprunt(Jack, ChatBotté, new DateTime(2023, 11, 1));
            maBibliotheque.EmprunterLivre(Jack, ChatBotté, emprunt.DateEmprunt);

            Console.WriteLine($"Durée d'emprunt : {emprunt.CalculerDuree().Days} jours");

            // Retour du livre
            emprunt.DateRetour = new DateTime(2023, 11, 4);
            Console.WriteLine($"Durée d'emprunt après retour : {emprunt.CalculerDuree().Days} jours");

            // Emprunt de Cyrano de Bergerac par Emeline
            maBibliotheque.EmprunterLivre(Emeline, CyranoDeBergerac, new DateTime(2023, 12, 4));

            // Retourner le livre après quelques jours
            maBibliotheque.RetournerLivre(Jack, ChatBotté, DateTime.Now.AddDays(7));

            // Afficher la liste des emprunts
            maBibliotheque.AfficherEmprunts();
        }
    }
}
