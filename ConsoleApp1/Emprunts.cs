using ConsoleApp1;

public class Emprunt
{
    public Membres Emprunteur;
    public Livres LivreEmprunte;
    public DateTime DateEmprunt;
    public DateTime? DateRetour; 

    public Emprunt(Membres emprunteur, Livres livreEmprunte, DateTime dateEmprunt)
    {
        this.Emprunteur = emprunteur;
        this.LivreEmprunte = livreEmprunte;
        this.DateEmprunt = dateEmprunt;
        this.DateRetour = null; // Initialement, le livre n'est pas retourné
    }

    public TimeSpan CalculerDuree()
    {
        DateTime dateFin = DateRetour ?? DateTime.Now;
        TimeSpan tempsEmprunt = dateFin - DateEmprunt; // Calcule la durée
        return tempsEmprunt;
    }
    public void RetournerLivre(DateTime dateRetour)
    {
        DateRetour = dateRetour;
    }

    public override string ToString()
    {
        string toString = DateRetour.HasValue ? DateRetour.Value.ToString("dd MMMM yyyy") : "Pas encore rendu";
        return $"Emprunteur : {Emprunteur}\nLivre : {LivreEmprunte}\nDate d'emprunt : {DateEmprunt:dd MMMM yyyy}\nDate de retour : {toString}";
    }
}


