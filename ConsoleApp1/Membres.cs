//membres
//livres
//emprunts
//bibliothèque
namespace Program
{
    public class Membres
    {
        string Nom;
        string Prenom;
        DateOnly DateNaissance;

        public Membres(string nom, string prenom, DateOnly dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            string toString = String.Format($"Le membre se nomm {this.Prenom} {this.Nom}\nil est née :{this.DateNaissance}");
            return toString;
        }
    }
}