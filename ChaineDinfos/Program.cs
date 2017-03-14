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
            Envoye envoye = new Envoye();
            envoye.Prenom = "Jean";
            envoye.Nom = "Luc";
            envoye.Theme = "Sport";
            envoye.PosteDeLEnvoye = Poste.cameraman;
            Reportage finalDePetanque = envoye.Rediger("Mon reportage", DateTime.Now, "Mon titre");
             
        }                 
    }
}
