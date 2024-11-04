//emprunts
//bibliothèque
namespace ConsoleApp1
{
    public class Membres
    {
        public string Nom;
        public string Prenom;
        public DateTime DateNaissance;

        public Membres(string nom, string prenom, DateTime dateNaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            string toString = String.Format($"Le membre se nom {this.Prenom} {this.Nom}\nil est née :{DateNaissance.ToString("dd MMMM yyyy")}");
            return toString;
        }

    }
}