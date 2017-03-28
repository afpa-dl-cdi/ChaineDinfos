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
            Reportage finalDePetanque = envoye.Rediger("Mon reportage", DateTime.Now, "Mon titre");

            Accroche.bonjour();                     //appel d'une classe et d'une méthode statique 

            Envoye samSoungue = new Envoye(); 
            Redacteur ppd = new Redacteur();
            Redacteur dp = new Redacteur();
            Redacteur cc = new Redacteur();

            Console.WriteLine("nombre de journaliste : {0}", Journaliste.nombreDeJournalisteCrees()); // appel d'une variable statique (d'une classe non statique)

        }                 
    }
}
 