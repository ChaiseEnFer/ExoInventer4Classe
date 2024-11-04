//livres
//emprunts
//bibliothèque
namespace ConsoleApp1
{
    public class Membres
    {
        public string Nom;
        public string Prenom;
        public string DateNaissance;

        public Membres(string nom, string prenom, string dateNaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            string toString = String.Format($"Le membre se nomm {this.Prenom} {this.Nom}\nil est née :{this.DateNaissance}");
            return toString;
        }

    }
}