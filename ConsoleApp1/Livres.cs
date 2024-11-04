using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Livres
    {
        string Titre;
        string Auteur;
        string ISBN;
        int AnneePublication;
        public Livres(int anneePublication, string auteur, string Isbn, string titre)
        {
            this.AnneePublication = anneePublication;
            this.Auteur = auteur;
            this.ISBN = Isbn;
            this.Titre = titre;
        }

        private string AfficherInfos()
        {
            string Infos = String.Format($"Le livre : {this.Titre}\nécrit par : {this.Auteur}\npublié en : {AnneePublication}\n Numéro personnel et unique d’un livre : {this.ISBN}"); //rajouter le lien quand y aura la classe Emprunt et mettre cte ligne dans le ToString()
            return Infos;

        }
        public override string ToString()
        {
            string tostring = AfficherInfos();
            return tostring;
        }
    }
}