using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bibliotheque
    {
        string Nom;
        string Adresse;
        private List<Livres> livres = new List<Livres>();
        private List<Emprunt> LivreEmprunter = new List<Emprunt>();

        public Bibliotheque(string nom, string adresse)
        {
            this.Nom = nom;
            this.Adresse = adresse;
        }


        // Méthode pour ajouter un livre à la bibliothèque
        public void AjouterLivre(string titre, string auteur, string Isbn,int anneePublication)
        {
            Livres nouveauLivre = new Livres(anneePublication, auteur,Isbn, titre);
            livres.Add(nouveauLivre);
            Console.WriteLine($"Le livre '{titre}' a été ajouté à la bibliothèque.");
        }

        public void emprunterLivre(Membres membre,Livres livres, DateTime dateEmprunt)
        {
            Emprunt livreEmprunte = new Emprunt(membre,livres, dateEmprunt);
            LivreEmprunter.Add(livreEmprunte);
            Console.WriteLine($"Le livre '{livres}' a été emprunter par : '{membre}'\n le {dateEmprunt} ");
        }


    }
}
