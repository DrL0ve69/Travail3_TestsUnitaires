namespace Travail3_TestsUnitaires.Models;

public class Client
{
    public string Nom {  get; set; }
    public string Prenom { get; set; }
    public string Courriel { get; set; }
    public int Numero { get; set; }
    public Client() { }

    public Client(string nom, string prenom, string courriel, int numero)
    {
        Nom = nom;
        Prenom = prenom;
        Courriel = courriel;
        Numero = numero;
    }
}
