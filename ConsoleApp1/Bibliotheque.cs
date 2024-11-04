
using ConsoleApp1;

public class Bibliotheque
{
    string Nom;
    string Adresse;
    private List<Livres> livresDisponibles = new List<Livres>();
    private List<Emprunt> emprunts = new List<Emprunt>();

    public Bibliotheque(string nom, string adresse)
    {
        Nom = nom;
        Adresse = adresse;
    }

    // Méthode pour ajouter un livre à la bibliothèque
    public void AjouterLivre(string titre, string auteur, string isbn, int anneePublication)
    {
        Livres nouveauLivre = new Livres(anneePublication, auteur, isbn, titre);
        livresDisponibles.Add(nouveauLivre);
        Console.WriteLine($"Le livre '{titre}' a été ajouté à la bibliothèque.");
    }

    // Méthode pour emprunter un livre
    public void EmprunterLivre(Membres emprunteur, Livres livreEmprunte, DateTime dateEmprunt)
    {
        if (livresDisponibles.Contains(livreEmprunte))
        {
            Emprunt nouvelEmprunt = new Emprunt(emprunteur, livreEmprunte, dateEmprunt);
            emprunts.Add(nouvelEmprunt);
            livresDisponibles.Remove(livreEmprunte); // Enlève le livre des disponibles
            Console.WriteLine($"Le livre '{livreEmprunte.Titre}' a été emprunté par {emprunteur}.");
        }
        else
        {
            Console.WriteLine($"Le livre '{livreEmprunte.Titre}' n'est pas disponible.");
        }
    }

    // Méthode pour retourner un livre
    public void RetournerLivre(Membres membre, Livres livre, DateTime dateRetour)
    {
        // Recherche de l'emprunt correspondant (sans date de retour définie)
        Emprunt emprunt = emprunts.FirstOrDefault(e => e.Emprunteur == membre && e.LivreEmprunte == livre && !e.DateRetour.HasValue);

        if (emprunt != null)
        {
            emprunt.RetournerLivre(dateRetour); // Met à jour la date de retour
            livresDisponibles.Add(livre); // Remet le livre dans les disponibles
            Console.WriteLine($"Le livre '{livre.Titre}' a été retourné par {membre}.");
        }
        else
        {
            Console.WriteLine($"Aucun emprunt actif trouvé pour le livre '{livre.Titre}' par {membre}.");
        }
    }

    // Méthode pour afficher tous les emprunts
    public void AfficherEmprunts()
    {
        Console.WriteLine("Liste des emprunts :");
        foreach (Emprunt emprunt in emprunts)
        {
            Console.WriteLine(emprunt.ToString());
        }
    }
}
