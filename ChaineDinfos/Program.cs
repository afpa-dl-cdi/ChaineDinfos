using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfos
{
    class Program
    {
        static void Main(string[] args)
        {
            Envoye envoye = new Envoye("Jean");
            envoye.Nom = "Luc";
            envoye.Theme = "Sport";
            envoye.PosteDeLEnvoye = Poste.cameraman;
            Reportage finalDePetanque = envoye.Filmer();
            Envoye e = new Envoye(joursDeLaMission: 20, departementDeLaMission: "sport");

            Accroche.bonjour(); // appelle d'une classe et sa méthode statique

        }                 
    }
}
